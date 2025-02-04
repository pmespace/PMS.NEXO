////using System;
using System.Net;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using COMMON;
using Newtonsoft.Json.Linq;
using System.Threading;
using Listener;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using Listener.Shared;
using System.Runtime.Intrinsics.Arm;
using System;

namespace WSServer
{
	public static class WSServer
	{
		#region constructor
		#endregion

		#region properties
		public const string DEFAULT_LOG_FILE_NAME = "wsserver.log";
		public const string DEFAULT_SETTINGS_FILE_NAME = "wsserver.settings.json";
		public static CancellationTokenSource Source { get; } = new CancellationTokenSource();
		public static bool IsStarted { get; private set; } = false;
		static public WebSocket WS { get; private set; } = null;
		public static CancellationToken token = Source.Token;
		#endregion

		#region private properties
		static object mylock = new object();
		static WSSettings Settings;
		static CWSClients WSClients = new CWSClients();
		#endregion

		#region classes
		class CWSClients : ConcurrentDictionary<string, WSContext>
		{
			public override string ToString()
			{
				var l = this.ToArray();
				bool equal0 = 0 == l.Length;
				bool lessthan2 = 2 <= l.Length;
				string s = $"Currently {l.Length} client{(lessthan2 ? "s" : string.Empty)} connected" + (!equal0 ? Chars.CRLF : string.Empty);
				for (int i = 1; i <= l.Length; i++)
					s += l[i - 1].ToString() + (l.Length != i ? Chars.CRLF : string.Empty);
				return s;
			}
		}
		class WSContext
		{
			public WSContext()
			{
				Requests = new WSStatistics();
				Replies = new WSStatistics();
			}
			public string ID { get; set; }
			public DateTime Connection
			{ get; private set; }
			public WSStatistics Requests { get; }
			public WSStatistics Replies { get; }
			public override string ToString() { return $"Connected at : {Connection}; [Request: {Requests}]; [Replies: {Replies}]"; }
		}
		class WSStatistics
		{
			public WSStatistics() { Messages = new CSafeList<WSMessage>(); }
			CSafeList<WSMessage> Messages { get; }
			public int NbMessages { get => Messages.Count; }
			public double TotalSize { get; private set; }
			public CSafeList<WSMessage> GetMessages() { return new CSafeList<WSMessage>(Messages); }
			public bool Add(string msg) { return Messages.Add(new WSMessage(msg)); }
			public override string ToString() { return $"{NbMessages} for {TotalSize} bytes"; }
		}
		class WSMessage
		{
			public WSMessage(string msg)
			{
				if (default == msg) throw new WSMessageException();
				Timestamp = DateTime.Now;
				Message = msg;
			}
			public string Message { get; }
			public DateTime Timestamp { get; }
			public override string ToString() { return $"[{Timestamp.ToString("s")}] {Message}"; }
		}
		class WSMessageException : Exception { }
		#endregion

		#region methods
		enum WSAction
		{
			Error = -1,
			Connection,
			Login,
			LoginOK,
			LoginKO,
			ReceiveReplyOrNotification,
			ReceivedReply,
			ReceivedNotification,
		}

		public static async void Start(string settingsFileName, ManualResetEvent startedEvt, ManualResetEvent endedEvt)
		{
			if (ReadSettings(settingsFileName))
			{
				// start the web server
				var builder = WebApplication.CreateBuilder();
				builder.WebHost.UseUrls($"http://localhost:{Settings.WSPort}");
				var app = builder.Build();
				app.UseWebSockets();
				app.Map("/ws", async context =>
				{
					Guid guid = Guid.NewGuid();
					try
					{
						IPEndPoint endpoint = new IPEndPoint(context.Connection.RemoteIpAddress, context.Connection.RemotePort);
						string sendpoint = endpoint.ToString();
						CLogger.TRACE($"[{sendpoint}] incoming connection");
						if (context.WebSockets.IsWebSocketRequest)
						{
							using (var webSocket = await context.WebSockets.AcceptWebSocketAsync())
							{
								try
								{
									// try adding the client to the list of surrent clients
									if (WSClients.TryAdd(sendpoint, new WSContext()))
									{
										WS = webSocket;
										WSAction wsaction = WSAction.Login;
										string s = string.Empty;
										byte[] ab = new byte[1024 * 5];
										CListenerReply reply;
										//CListenerRequest request;
										CListenerClientLoginRequest loginRequest;
										CListenerClientLoginResponse loginResponse = new CListenerClientLoginResponse();
										while (WebSocketState.Open == webSocket.State && !token.IsCancellationRequested)
										{
											switch (wsaction)
											{
												case WSAction.Login:
													{
														// wait login message
														CLogger.DEBUG($"[{sendpoint}] waiting security details");
														var res = await webSocket.ReceiveAsync(new ArraySegment<byte>(ab), token);
														s += Encoding.UTF8.GetString(ab, 0, res.Count);
														if (res.EndOfMessage)
														{
															try
															{
																// convert order to login message
																loginRequest = CJson<CListenerClientLoginRequest>.Deserialize(s);
																if (null != loginRequest)
																{
																	// test login credentials ...
																	CLogger.INFORMATION($"[{sendpoint}] received security details: {loginRequest._extendedData}");
																	WSClients[sendpoint].ID = loginRequest._extendedData.ToString().ToSHA256();

																	// consider OK
																	wsaction = WSAction.LoginOK;
																	CLogger.TRACE($"[{sendpoint}] connection granted with ID=[{WSClients[sendpoint].ID}]");
																}
																else
																{
																	wsaction = WSAction.LoginKO;
																}
															}
															catch (Exception ex)
															{
																CLog.EXCEPT(ex);
															}
															s = string.Empty;
														}
													}
													break;

												case WSAction.LoginOK:
												case WSAction.LoginKO:
													{
														loginResponse.Granted = (WSAction.LoginOK == wsaction ? true : false);
														s = CJson<CListenerClientLoginResponse>.Serialize(loginResponse);
														CLogger.TRACE($"[{sendpoint}] sending login result: {wsaction}");
														await webSocket.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(s)), WebSocketMessageType.Text, true, token);
														switch (wsaction)
														{
															case WSAction.LoginOK:
																wsaction = WSAction.ReceiveReplyOrNotification;
																break;
															case WSAction.LoginKO:
																wsaction = WSAction.Login;
																break;
														}
														s = string.Empty;
													}
													break;

												case WSAction.ReceiveReplyOrNotification:
													{
														// wait login message
														var res = await webSocket.ReceiveAsync(new ArraySegment<byte>(ab), token);
														s += Encoding.UTF8.GetString(ab, 0, res.Count);
														if (res.EndOfMessage)
														{
															try
															{
																// convert order to login message
																reply = CJson<CListenerReply>.Deserialize(s);
																if (null != reply)
																{
																	if (reply.Notification)
																	{
																		CLogger.TRACE($"[{sendpoint}] received notification [{reply}]");
																	}
																	else
																	{
																		CLogger.TRACE($"[{sendpoint}] received reply [{reply}]");
																	}
																}
																else
																{
																	// do nothing
																}
															}
															catch (Exception ex)
															{
																CLog.EXCEPT(ex);
															}
															s = string.Empty;
														}
													}
													break;

												case WSAction.ReceivedReply:
												case WSAction.ReceivedNotification:
													break;
											}
										}
									}
									else
										CLogger.ERROR($"[{sendpoint}] Failed to insert {sendpoint} in the list of current clients");
								}
								catch (Exception ex)
								{
									CLogger.EXCEPT(ex, $"[{sendpoint}]");
								}
								finally
								{
									CLogger.TRACE($"[{sendpoint}] Connection from {sendpoint} has been closed");
								}
							}
						}
						else
						{
							context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
							CLogger.WARNING($"[{sendpoint}] received HTTP request, connection from {sendpoint} is being closed with status {context.Response.StatusCode}");
						}
					}
					catch (Exception ex)
					{
						CLogger.EXCEPT(ex);
					}
				});

				startedEvt.Set();
				await app.RunAsync();
			}
			endedEvt.Set();
		}

		public static async void SendRequest(string filename, ManualResetEvent evt)
		{
			if (null != WS)
			{
				var json = new CJson<CListenerRequest>(filename);
				var request = json.ReadSettings();
				if (null != request)
				{
					try
					{
						//await WS.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(CJson<CListenerRequest>.Serialize(request))), WebSocketMessageType.Text, true, token);

						string s = CJson<CListenerRequest>.Serialize(request);
						byte[] ab = Encoding.UTF8.GetBytes(s);
						ArraySegment<byte> arb = new ArraySegment<byte>(ab);
						await WS.SendAsync(arb, WebSocketMessageType.Text, true, token);

						Console.WriteLine($"request sent [{request}]");
					}
					catch (Exception ex)
					{
						CLogger.EXCEPT(ex);
					}
				}
			}
			evt.Set();
		}

		static bool ReadSettings(string settingsFileName)
		{
			// read settings
			CJson<WSSettings> json = new CJson<WSSettings>(settingsFileName);
			Settings = json.ReadSettings();
			if (default == Settings)
			{
				Settings = new WSSettings();
				json.WriteSettings(Settings, null, false);
				CLogger.ERROR($"Failed to load settings, using default [{Settings}]");
			}
			CLog.SeverityToLog = TLog.TRACE;
			return true;
		}
		#endregion
	}
}
