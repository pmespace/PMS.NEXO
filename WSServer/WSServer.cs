using System;
using System.Diagnostics;
using System.Net;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using COMMON;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using System.Threading;
using Listener;

namespace WSServer
{
	internal class Program
	{
		static ManualResetEvent evt;
		static WebSocket WS = null;
		static bool IsConnected = false;
		static void Main(string[] args)
		{
			CLog.LogFileName = "wsserver.log";
			CLog.SeverityToLog = TLog.DEBUG;
			evt = new ManualResetEvent(false);
			StartServer();
			evt.WaitOne();

			var listener = new CListener();
			listener.Start(CListener.LISTENER_DEFAULT_SETTINGS_FILE);
			ConsoleKeyInfo key;
			do
			{
				Console.WriteLine("Press ESC to stop server, T to start a test");
				key = Console.ReadKey();
				if (ConsoleKey.T == key.Key && IsConnected)
					TestListener(listener);
			} while (ConsoleKey.Escape != key.Key);
		}

		static async void TestListener(CListener listener)
		{
			TestListenerType type = new TestListenerType() { FileToUse = "listener.request.json", Port = listener.Port, IP = listener.IP };

			type.FileToUse = CMisc.Input("File to use", "listener.request.json", out bool isdef);
			if (string.IsNullOrEmpty(type.FileToUse))
			{
				Console.WriteLine("Invalid test file");
				return;
			}

			var json = new CJson<CListenerRequest>(type.FileToUse);
			var request = json.ReadSettings();
			if (null != request)
			{
				await WS.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(CJson<CListenerRequest>.Serialize(request))), WebSocketMessageType.Text, true, CancellationToken.None);
				Console.WriteLine($"Request sent [{request}]");
			}
			return;
		}
		class TestListenerType
		{
			public uint Port;
			public string FileToUse;
			public string IP;
		}


		enum Action
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
		static async void StartServer()
		{
			Console.Title = "Server";
			var builder = WebApplication.CreateBuilder();
			builder.WebHost.UseUrls("http://localhost:6666");
			var app = builder.Build();
			app.UseWebSockets();
			HttpContext context;
			app.Map("/ws", async context =>
			{
				Console.WriteLine("Incoming connection");
				if (context.WebSockets.IsWebSocketRequest)
				{
					Action action;
					using (var webSocket = await context.WebSockets.AcceptWebSocketAsync())
					{
						//while (true)
						//{
						//	//await webSocket.SendAsync(Encoding.ASCII.GetBytes($"Test - {DateTime.Now}"), WebSocketMessageType.Text, true, CancellationToken.None);
						//	//await Task.Delay(1000);
						//}

						CancellationTokenSource source = new CancellationTokenSource();
						CancellationToken token = source.Token;

						try
						{
							WS = webSocket;
							action = Action.Login;
							string s = string.Empty;
							byte[] ab = new byte[1024 * 5];
							CListenerReply reply;
							CListenerRequest request;
							CListenerClientLoginRequest loginRequest;
							CListenerClientLoginResponse loginResponse = new CListenerClientLoginResponse();
							while (WebSocketState.Open == webSocket.State && !token.IsCancellationRequested)
							{
								IsConnected = true;
								switch (action)
								{
									case Action.Login:
										{
											// wait login message
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

														// consider OK
														action = Action.LoginOK;
													}
													else
													{
														// do nothing
													}
												}
												catch (Exception ex)
												{
												}
												s = string.Empty;
											}
										}
										break;

									case Action.LoginOK:
									case Action.LoginKO:
										{
											loginResponse.Granted = (Action.LoginOK == action ? true : false);
											s = CJson<CListenerClientLoginResponse>.Serialize(loginResponse);
											await webSocket.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(s)), WebSocketMessageType.Text, true, token);
											switch (action)
											{
												case Action.LoginOK:
													action = Action.ReceiveReplyOrNotification;
													break;
												case Action.LoginKO:
													action = Action.Login;
													break;
											}
											s = string.Empty;
										}
										break;

									case Action.ReceiveReplyOrNotification:
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
															Console.WriteLine($"Received notification [{reply}]");
														}
														else
														{
															Console.WriteLine($"Received reply [{reply}]");
														}
													}
													else
													{
														// do nothing
													}
												}
												catch (Exception ex)
												{
												}
												s = string.Empty;
											}
										}
										break;

									case Action.ReceivedReply:
									case Action.ReceivedNotification:
										break;
								}


							}
							IsConnected = false;
						}
						catch (Exception ex)
						{

						}
					}
				}
				else
				{
					context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
				}
			});

			evt.Set();
			await app.RunAsync();
		}
	}
}