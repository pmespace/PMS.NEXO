using System.Runtime.InteropServices;
using System.Reflection;
using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;
using System.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using NEXO.Properties;
using COMMON;

namespace NEXO
{
	//[Guid("B4ECE1AD-7697-46F6-965C-CE7B341E2D32")]
	//[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	//[ComVisible(true)]
	//internal interface INexoRetailerServerMessageHeaderValidator
	//{
	//	[DispId(1)]
	//	MessageTypeEnumeration Type { get; }
	//	[DispId(2)]
	//	MessageClassEnumeration Class { get; }
	//	[DispId(3)]
	//	MessageCategoryEnumeration Category { get; }
	//	[DispId(4)]
	//	NexoTextString POIID { get; }
	//	[DispId(5)]
	//	NexoTextString SaleID { get; }
	//	[DispId(6)]
	//	NexoDeviceID DeviceID { get; }
	//	[DispId(7)]
	//	NexoServiceID ServiceID { get; }
	//	[DispId(8)]
	//	NexoProtocolVersion ProtocolVersion { get; }
	//	[DispId(100)]
	//	bool IsValid { get; }
	//}
	//[Guid("E9BA4737-C3FA-4898-80FA-29641E7D5A24")]
	//[ClassInterface(ClassInterfaceType.None)]
	/// <summary>
	/// This class allows verifying whether a message header is valid or not
	/// </summary>
	[ComVisible(false)]
	public class NexoMessageHeader//: INexoRetailerServerMessageHeaderValidator
	{
		#region constructors
		public NexoMessageHeader(MessageHeaderType mh, NexoProtocolVersion server = null)
		{
			Response = new NexoResponseType();
			Type = MessageHeaderToType(mh);
			Class = MessageHeaderToClass(mh);
			Category = MessageHeaderToCategory(mh);
			POIID = new NexoPOIID(mh.POIID);
			SaleID = new NexoSaleID(mh.SaleID);
			DeviceID = new NexoDeviceID(mh.DeviceID);
			ServiceID = new NexoServiceID(mh.ServiceID);
			ProtocolVersion = new NexoProtocolVersion() { Value = (MessageCategoryEnumeration.Login == Category ? mh.ProtocolVersion : null) };
			ServerVersion = server;
			Response.Result = ResultEnumeration.Success;
		}
		#endregion

		#region properties
		public MessageHeaderType MessageHeader
		{
			get => new MessageHeaderType() { DeviceID = this.DeviceID.Value, MessageCategory = this.Category.ToString(), MessageClass = this.Class.ToString(), MessageType = this.Type.ToString(), POIID = this.POIID.Value, ProtocolVersion = this.ProtocolVersion.Value, SaleID = this.SaleID.Value, ServiceID = this.ServiceID.Value };
		}
		public MessageHeaderType ReplyMessageHeader
		{
			get => new MessageHeaderType() { DeviceID = this.DeviceID.Value, MessageCategory = this.Category.ToString(), MessageClass = this.Class.ToString(), MessageType = MessageTypeEnumeration.Response.ToString(), POIID = this.POIID.Value, ProtocolVersion = this.ProtocolVersion.Value, SaleID = this.SaleID.Value, ServiceID = this.ServiceID.Value };
		}
		/// <summary>
		/// Version of protocol supported by the calling server
		/// </summary>
		private NexoProtocolVersion ServerVersion;
		/// <summary>
		/// Message type as a numeric value
		/// </summary>
		public MessageTypeEnumeration Type { get; private set; }
		/// <summary>
		/// Message class as a numeric value
		/// </summary>
		public MessageClassEnumeration Class { get; private set; }
		/// <summary>
		/// Message category as a numeric value
		/// </summary>
		public MessageCategoryEnumeration Category { get; private set; }
		/// <summary>
		/// POI involved
		/// </summary>
		public NexoTextString POIID { get; private set; }
		/// <summary>
		/// Sale involved
		/// </summary>
		public NexoTextString SaleID { get; private set; }
		/// <summary>
		/// DeviceID to use
		/// </summary>
		public NexoDeviceID DeviceID { get; private set; }
		/// <summary>
		/// ServiceID to use
		/// </summary>
		public NexoServiceID ServiceID { get; private set; }
		/// <summary>
		/// Protocol version of requester
		/// </summary>
		public NexoProtocolVersion ProtocolVersion { get; private set; }
		/// <summary>
		/// Response to send if an error has occurred 
		/// </summary>
		public NexoResponseType Response { get; private set; }
		/// <summary>
		/// Indicates if the request can be processed based on MessageHeader
		/// </summary>
		public bool IsValid
		{
			get
			{
				bool fOK = false;
				// test message specifities
				switch (Type)
				{
					case MessageTypeEnumeration.Request:
						switch (Class)
						{
							case MessageClassEnumeration.Service:
								switch (Category)
								{
									case MessageCategoryEnumeration.Abort:
										break;
									case MessageCategoryEnumeration.Admin:
										break;
									case MessageCategoryEnumeration.BalanceInquiry:
										break;
									case MessageCategoryEnumeration.Batch:
										break;
									case MessageCategoryEnumeration.CardAcquisition:
										break;
									case MessageCategoryEnumeration.Diagnosis:
										break;
									case MessageCategoryEnumeration.EnableService:
										break;
									case MessageCategoryEnumeration.Event:
										break;
									case MessageCategoryEnumeration.GetTotals:
										break;
									case MessageCategoryEnumeration.Login:
										// mandatory data
										if (ProtocolVersion.IsEmpty)
											NexoErrors.MessageFormatMandatoryDataAbsent(Response, ProtocolVersion.Name);
										else if (ServerVersion.AsDecimal < ProtocolVersion.AsDecimal)
											NexoErrors.UnavailableServiceTooOldProtocolVersion(Response, ProtocolVersion.Value, ServerVersion.Value);
										// the above errors are not considered fatal
										fOK = true;
										break;
									case MessageCategoryEnumeration.Logout:
										fOK = true;
										break;
									case MessageCategoryEnumeration.Loyalty:
										break;
									case MessageCategoryEnumeration.Payment:
										fOK = true;
										break;
									case MessageCategoryEnumeration.Reconciliation:
										break;
									case MessageCategoryEnumeration.Reversal:
										fOK = true;
										break;
									case MessageCategoryEnumeration.StoredValue:
										break;
									case MessageCategoryEnumeration.TransactionStatus:
										break;
								}
								if (!(fOK = fOK && !ServiceID.IsEmpty))
									NexoErrors.MessageFormatMandatoryDataAbsent(Response, ServiceID.Name);
								break;
							case MessageClassEnumeration.Device:
								switch (Category)
								{
									case MessageCategoryEnumeration.Abort:
										break;
									case MessageCategoryEnumeration.CardReaderAPDU:
										break;
									case MessageCategoryEnumeration.CardReaderInit:
										break;
									case MessageCategoryEnumeration.CardReaderPowerOff:
										break;
									case MessageCategoryEnumeration.Display:
										break;
									case MessageCategoryEnumeration.Input:
										fOK = true;
										break;
									case MessageCategoryEnumeration.InputUpdate:
										break;
									case MessageCategoryEnumeration.PIN:
										break;
									case MessageCategoryEnumeration.Print:
										fOK = true;
										break;
									case MessageCategoryEnumeration.Sound:
										break;
									case MessageCategoryEnumeration.Transmit:
										break;
								}
								if (!(fOK = fOK && !DeviceID.IsEmpty))
									NexoErrors.MessageFormatMandatoryDataAbsent(Response, DeviceID.Name);
								break;
							case MessageClassEnumeration.Event:
							default:
								break;
						}
						break;
					case MessageTypeEnumeration.Response:
					case MessageTypeEnumeration.Notification:
					default:
						break;
				}
				// test values
				if (!(fOK = fOK && !SaleID.IsEmpty))
					NexoErrors.MessageFormatMandatoryDataAbsent(Response, SaleID.Name);
				if (!(fOK = fOK && !POIID.IsEmpty))
					NexoErrors.MessageFormatMandatoryDataAbsent(Response, POIID.Name);
				// test final result
				return fOK;
			}
		}
		#endregion

		#region methods
		private static MessageTypeEnumeration MessageHeaderToType(MessageHeaderType mh)
		{
			//return (MessageTypeEnumeration)CMisc.StringToEnumValue(typeof(MessageTypeEnumeration), mh.MessageType);
			return (MessageTypeEnumeration)CMisc.GetEnumValue(typeof(MessageTypeEnumeration), mh.MessageType);
		}
		private static MessageClassEnumeration MessageHeaderToClass(MessageHeaderType mh)
		{
			//return (MessageClassEnumeration)CMisc.StringToEnumValue(typeof(MessageClassEnumeration), mh.MessageClass);
			return (MessageClassEnumeration)CMisc.GetEnumValue(typeof(MessageClassEnumeration), mh.MessageClass);
		}
		private static MessageCategoryEnumeration MessageHeaderToCategory(MessageHeaderType mh)
		{
			//return (MessageCategoryEnumeration)CMisc.StringToEnumValue(typeof(MessageCategoryEnumeration), mh.MessageCategory);
			return (MessageCategoryEnumeration)CMisc.GetEnumValue(typeof(MessageCategoryEnumeration), mh.MessageCategory);
		}
		public override string ToString()
		{
			const string SEP = " - ";
			return "MessageCategory: " + Category.ToString()
				+ SEP + "MessageClass: " + Class.ToString()
				+ SEP + "MessageType: " + Type.ToString()
				+ SEP + "SaleID: " + SaleID.Value
				+ SEP + "POIID: " + POIID.Value
				+ SEP + "ServiceID: " + ServiceID.Value
				+ SEP + "DeviceID: " + DeviceID.Value
				+ (string.IsNullOrEmpty(ProtocolVersion.Value) ? null : SEP + "ProtocolVersion: " + ProtocolVersion.Value);
		}
		#endregion
	}
}
