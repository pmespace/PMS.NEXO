#define USESECURITY

#if USEWSINTERFACE

using System;
using System.Net;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Text;

#if NETCOREAPP
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
#else
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
#endif

using COMMON;
using System.Threading;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using Listener.Shared;
using Listener.Properties;

namespace Listener
{
	public static class CWSListener
	{
		#region constructor
		#endregion

		#region consts
		#endregion

		#region enums
		enum WSAction
		{
			Error = -1,
			Connection,
			Login,
			LoginOK,
			LoginKO,
			Connect,
			ReceiveAsync,
			ReceivedReply,
			ReceivedNotification,
			Disconnect,
			Stop,
		}
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

		#region properties
		public static bool IsStarted { get; private set; } = false;
		public static WebSocket WS { get; private set; } = null;
		public static CancellationTokenSource Source { get; private set; }
		static CancellationToken token = CancellationToken.None;
		#endregion

		#region private properties
		static CWSClients WSClients = new CWSClients();
		static object mylock = new object();
		#endregion

		#region methods
		/// <summary>
		/// Starts the listener WS interface
		/// The interface is used to receive receive monitoring orders and eventually orders from a sale system; it can be started for both or only orders
		/// </summary>
		/// <param name="settings"><see cref="CSettings"/> to use for this process</param>
		/// <param name="sync">A <see cref="CSynchronize"/> object to synchronize start and stop</param>
		/// <param name="acceptOrdersAndCommands"><see langword="true"/> if orders and commands are, false if only orders are accepted</param>
		/// <param name="onStop">Function called when the procedure ends</param>
		public static async void Start(CListenerSettings settings, CSynchronize sync, bool acceptOrdersAndCommands, FOnInterfaceStopped onStop)
		{
			try
			{
				Source = new CancellationTokenSource();
				token = Source.Token;

				// start the web server
				var builder = WebApplication.CreateBuilder();
				//builder.WebHost.UseUrls($"http://localhost:{settings.Server.WSServer.WSPort}"); // !!! using localhost doesn't work
				builder.WebHost.UseUrls($"http://{CStream.Localhost()}:{settings.Server.WSServer.WSPort}");
				var app = builder.Build();
				app.UseWebSockets();

				#region aaa
				app.Map(settings.Server.WSServer.WSMap, async context =>
				{
					try
					{
						IPEndPoint endpoint = new IPEndPoint(context.Connection.RemoteIpAddress, context.Connection.RemotePort);
						string sendpoint = endpoint.ToString();
						CLog.TRACE($"[{sendpoint}] {Resources.WSInterfaceIncomingConnection}");
						if (context.WebSockets.IsWebSocketRequest)
						{
							using (var webSocket = await context.WebSockets.AcceptWebSocketAsync())
							{
								// try adding the client to the list of current clients
								if (WSClients.TryAdd(sendpoint, new WSContext()))
								{
									WS = webSocket;
									WSAction wsaction = settings.Server.UseSecurity ? WSAction.Login : WSAction.Connect;
									string s = string.Empty;
									byte[] ab = new byte[1024 * 5];
									//CListenerReply reply;
									//CListenerReplyEx replyEx;
									//CListenerRequest request;
									//CListenerRequestEx requestEx;
									CListenerClientLoginRequest loginRequest;
									CListenerClientLoginResponse loginResponse = new CListenerClientLoginResponse();
									CStreamClientSettings clientSettings = null;
									CStreamClientIO streamIO = null;
									string statusDescription = string.Empty;
									//CancellationTokenSource innerSource = new CancellationTokenSource();
									//CancellationToken innerToken = innerSource.Token;
									CThread thread;
									try
									{
										while
										(
											WebSocketState.Open == webSocket.State
											&& !token.IsCancellationRequested
										//&& !innerToken.IsCancellationRequested
										)
										{
											switch (wsaction)
											{
												case WSAction.Login:
													{
														// wait login message
														CLog.DEBUG($"[{sendpoint}] {Resources.WSInterfaceWaitingSecurityDetails}");
														var res = await ReceiveAsync(webSocket, token /*innerToken*/);
														if (!res.IsNullOrEmpty())
														{
															try
															{
																// convert order to login message
																loginRequest = CJson<CListenerClientLoginRequest>.Deserialize(s);
																if (null != loginRequest)
																{
																	// test login credentials ...
																	CLog.DEBUG($"[{sendpoint}] {string.Format(Resources.WSInterfaceReceivedSecurityDetails, new object[] { loginRequest._extendedData })}");
																	WSClients[sendpoint].ID = loginRequest._extendedData.ToString().ToSHA256();

																	// consider OK
																	wsaction = WSAction.LoginOK;
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
														CLog.DEBUG($"[{sendpoint}] {string.Format(Resources.SendingLoginResult, new object[] { wsaction.ToString() })}");
														await webSocket.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(s)), WebSocketMessageType.Text, true, token /*innerToken*/);
														switch (wsaction)
														{
															case WSAction.LoginOK:
																CLog.TRACE($"[{sendpoint}] {string.Format(Resources.WSInterfaceLoginOK, new object[] { WSClients[sendpoint].ID })}");
																wsaction = WSAction.Connect;
																break;
															case WSAction.LoginKO:
																CLog.TRACE($"[{sendpoint}] {string.Format(Resources.WSInterfaceLoginKO, new object[] { WSClients[sendpoint].ID })}");
																wsaction = WSAction.Login;
																break;
														}
														s = string.Empty;
													}
													break;

												case WSAction.Connect:
													{
														// open connection to the listener
														clientSettings = new CStreamClientSettings()
														{
															IP = CStream.Localhost(),
															Port = settings.Server.Port,
															ReceiveTimeout = 0,
														};
														streamIO = CStream.Connect(clientSettings);
														if (null != streamIO)
														{
															CLog.DEBUG($"[{sendpoint}] {string.Format(Resources.WSInterfaceConnectedToListener, new object[] { clientSettings.FullIP })}");

															// start reading thread
															thread = new CThread
															{
																Name = Resources.ThreadNameWS,
															};
															thread.Start(ReceiveReplyThreadFunc,
																new CThreadData(),
																new SThreadParams()
																{
																	StreamIO = streamIO,
																	Token = token /*innerToken*/,
																	Source = Source /*innerSource*/,
																	WS = webSocket
																});

															wsaction = WSAction.ReceiveAsync;
														}
														else
														{
															statusDescription = CLog.ERROR(Resources.WSInterfaceFailedToConnectToListener);
															wsaction = WSAction.Disconnect;
														}
													}
													break;

												case WSAction.Disconnect:
													{
														// disconnect the WS
														webSocket.Abort();
														try
														{
															await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, statusDescription, token /*innerToken*/);
														}
														catch (Exception ex)
														{
															CLog.EXCEPT(ex);
														}
														//innerSource.Cancel();
														Source.Cancel();
														CLog.DEBUG($"[{sendpoint}] {Resources.WSInterfaceDisconnected}");
													}
													break;

												case WSAction.ReceiveAsync:
													{
														CLog.DEBUG($"[{sendpoint}] {Resources.WSInterfaceWaitingForIncomingData}");
														// wait incoming message
														var res = await ReceiveAsync(webSocket, token /*innerToken*/);
														if (!res.IsNullOrEmpty())
														{
															// forward message to the server
															if (!CStream.Send(streamIO, res))
															{
																CLog.ERROR($"[{sendpoint}] {Resources.WSInterfaceFailedSendingDataToListener}");
																wsaction = WSAction.Disconnect;
															}
														}
													}
													break;

												case WSAction.Error:
													{
														CLog.ERROR($"[{sendpoint}] {Resources.UnknownError}");
													}
													break;

												case WSAction.ReceivedReply:
												case WSAction.ReceivedNotification:
													break;
											}
										}
									}
									catch (Exception ex)
									{
										CLog.EXCEPT(ex, $"[{sendpoint}]");
									}
									finally
									{
										// disconnect from the listener
										if (null != streamIO)
											CStream.Disconnect(streamIO);
										streamIO = null;
										CLog.TRACE($"[{sendpoint}] {string.Format(Resources.WSInterfaceConnectionHasBeenClosed, new object[] { sendpoint })}");
									}
								}
								else
									CLog.ERROR($"[{sendpoint}] {Resources.FailedInsertingConnectedClient}");
							}
						}
						else
						{
							context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
							CLog.WARNING($"[{sendpoint}] {string.Format(Resources.WSInterfaceNotWSRequest, new object[] { context.Response.StatusCode.ToString() })}");
						}
					}
					catch (Exception ex)
					{
						CLog.EXCEPT(ex);
					}
				});
				#endregion

				sync[0].Set();
				await app.RunAsync();
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			finally
			{
				sync[1].Set();
				onStop?.Invoke(0);
			}
		}

		/// <summary>
		/// Reads the WS returning
		/// </summary>
		/// <param name="ws">The WS to read</param>
		/// <returns>
		/// A string representing the received data, an empty string if no data or an error has occurred
		/// </returns>
		public static async Task<string> ReceiveAsync(WebSocket ws, CancellationToken token)
		{
			byte[] ab = new byte[1024 * 5];
			string s = string.Empty;
			try
			{
				var res = await ws.ReceiveAsync(new ArraySegment<byte>(ab), token);
				s += Encoding.UTF8.GetString(ab, 0, res.Count);
				if (res.EndOfMessage && !token.IsCancellationRequested)
				{
					return s;
				}
				else if (token.IsCancellationRequested)
				{
					CLog.INFORMATION(Resources.ConnectionHasBeenCancelled);
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			return string.Empty;
		}

		/// <summary>
		/// Thread function reading the socket waiting for messages to come back from the server and aimed at the sale system
		/// </summary>
		/// <param name="thread"></param>
		/// <param name="o"></param>
		/// <returns></returns>
		static int ReceiveReplyThreadFunc(CThread thread, object o = default)
		{
			ThreadResult res = ThreadResult.OK;
			SThreadParams parameters = (SThreadParams)o;
			try
			{
				string s;
				CListenerReply reply = null;
				while (!parameters.Token.IsCancellationRequested && !(s = CStream.ReceiveAsString(parameters.StreamIO)).IsNullOrEmpty() && null != (reply = CJson<CListenerReply>.Deserialize(s)))
				{
					// send the received data to the caller
					var task = parameters.WS.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(s)), WebSocketMessageType.Text, true, parameters.Token);
					CLog.TRACE($"{reply.Message} (WS {Resources.ReceivedMessage})");
					task.Wait();
					if (task.IsCompleted && !reply.Notification)
					{
						CLog.TRACE($"{reply}");
						break;
					}
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
				res = ThreadResult.Exception;
			}
			finally
			{
				parameters.Source.Cancel();
			}
			return (int)res;
		}
		struct SThreadParams
		{
			public WebSocket WS;
			public CStreamIO StreamIO;
			public CancellationToken Token;
			public CancellationTokenSource Source;
		}
		#endregion
	}
}

#endif
