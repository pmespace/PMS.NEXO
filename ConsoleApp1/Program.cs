using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMMON;
using NEXO;
using NEXO.Client;

namespace ConsoleApp1
{
	class Program
	{
		class Settings
		{
			public string IP { get; set; }
			public uint Port { get; set; }
			public int NbChars { get; set; }
		}
		static void Main(string[] args)
		{
			bool fContinue = true;
			do
			{
				CJson<Settings> json = new CJson<Settings>("console.settings.json");
				Settings settings = json.ReadSettings();
				if (null == settings)
				{
					json.WriteSettings(new Settings(), true);
					return;
				}
				settings.NbChars = 0 >= settings.NbChars ? 1 : settings.NbChars;
				NexoRetailerClient client = new NexoRetailerClient("saleID", "poiID");
				NexoRetailerClientSettings clientSettings = new NexoRetailerClientSettings()
				{
					ConnectionSettings = null,
					StreamClientSettings = new CStreamClientSettings()
					{
						IP = settings.IP,
						Port = settings.Port,
					},
				};
				Console.WriteLine($"IP: {settings.IP}");
				Console.WriteLine($"Port: {settings.Port}");
				Console.WriteLine($"Nb Chars: {settings.NbChars}");

				Console.WriteLine($"Connecting...");
				if (client.Connect(clientSettings))
				{
					Console.Write($"Connect => OK (press any key)");
					Console.ReadKey(true);
					Console.WriteLine();

					NexoLogin login = new NexoLogin();
					login.SaleID = client.SaleID;
					login.POIID = client.POIID;
					login.RequestApplicationName = "console";
					login.RequestCertificationCode = "N/A";
					login.RequestManufacturerID = "PMS";
					login.RequestOperatorID = "PME";
					login.RequestSoftwareVersion = "1.0";

					Console.WriteLine($"Sending login...");
					if (client.SendRequestSync(login, 15))
					{
						Console.Write($"Login => OK (press any key)");
						Console.ReadKey(true);
						Console.WriteLine();

						NexoDeviceInput input = new NexoDeviceInput();
						input.SaleID = client.SaleID;
						input.POIID = client.POIID;
						input.RequestDevice = DeviceEnumeration.CashierInput;
						input.RequestInfoQualify = InfoQualifyEnumeration.Document;
						input.RequestInputCommand = InputCommandEnumeration.TextString;

						Console.WriteLine($"Sending input...");
						if (client.SendRequestSync(input, 30))
							Console.Write($"Reading => {input.Response.Result}" + (null != input.ReplyData.InputResult.Input.TextInput ? $" => { input.ReplyData.InputResult.Input.TextInput}" : null));
						else
							Console.Write($"Reading => FAILED");
						Console.Write($" (press any key)");
						Console.ReadKey(true);
						Console.WriteLine();

						NexoDevicePrint print = new NexoDevicePrint();
						print.SaleID = client.SaleID;
						print.POIID = client.POIID;
						print.RequestDocumentQualifier = DocumentQualifierEnumeration.Document;
						print.RequestResponseMode = ResponseModeEnumeration.PrintEnd;
						print.RequestOutputFormat = OutputFormatEnumeration.Text;
						string bb = null;
						for (byte i = 0; i < settings.NbChars; i++)
							bb += (i % 10).ToString();
						OutputTextType texttoprint = new OutputTextType() { Value = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(bb)) };
						print.RequestData.PrintOutput.OutputContent.OutputTextAddItem(texttoprint);

						Console.WriteLine($"Sending print [{print.RequestData.PrintOutput.OutputContent.OutputText[0]}]...");
						Console.ReadKey(true);
						if (client.SendRequestSync(print, 30))
							if (null != print.Response)
								Console.Write($"Printing {bb} => {print.Response.Result}");
							else
								Console.Write($"Printing {bb} => FAILED");
						else
							Console.Write($"Printing {bb} => FAILED");
						Console.Write($" (press any key)");
						Console.ReadKey(true);
						Console.WriteLine();
					}
					else
					{
						Console.WriteLine($"Login => Failed");
					}
					client.Disconnect();
				}
				else
				{
					Console.WriteLine($"Connect => FAILED");
				}
				Console.Write($"Do it again ? [ESC=no]");
				ConsoleKeyInfo key = Console.ReadKey(true);
				fContinue = (ConsoleKey.Escape != key.Key);
			} while (fContinue);
		}
	}
}
