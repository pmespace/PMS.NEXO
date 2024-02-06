using COMMON;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using COMMON;
using Newtonsoft.Json;
using Listener.Properties;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Listener
{
	public static class NeptingExtensions
	{
		public static StringBuilder StringBuilder(this string s) => default == s ? new StringBuilder(string.Empty) : new StringBuilder(s);
		public static string IntPtrToStringAnsi(this IntPtr s)
		{
			if (default != s)
			{
				try { return Marshal.PtrToStringAnsi(s); }
				catch (Exception) { }
			}
			return string.Empty;
		}
	}

	internal class CNepting
	{
		#region imports
		const string dllName = "myName";

		[DllImport(dllName, CharSet = CharSet.Ansi, EntryPoint = "InitNepLib")]
		public static extern int InitNepLibEx(StringBuilder connectionType);
		[DllImport(dllName, CharSet = CharSet.Ansi, EntryPoint = "CloseNepLib")]
		public static extern int CloseNepLibEx();

		[DllImport(dllName, CharSet = CharSet.Ansi, EntryPoint = "CreateNepMessage")]
		public static extern IntPtr CreateNepMessageEx();
		[DllImport(dllName, CharSet = CharSet.Ansi, EntryPoint = "FreeNepMessage")]
		public static extern int FreeNepMessageEx(IntPtr message);

		[DllImport(dllName, CharSet = CharSet.Ansi, EntryPoint = "SetNepField")]
		public static extern int SetNepFieldEx(IntPtr message, StringBuilder fieldName, StringBuilder fieldValue);
		[DllImport(dllName, CharSet = CharSet.Ansi, EntryPoint = "SendNepMessage")]
		public static extern int SendNepMessageEx(IntPtr message);
		[DllImport(dllName, CharSet = CharSet.Ansi, EntryPoint = "ReceiveNepMessage")]
		public static extern int ReceiveNepMessageEx(IntPtr message, int timeout);
		[DllImport(dllName, CharSet = CharSet.Ansi, EntryPoint = "GetNepField")]
		public static extern IntPtr GetNepFieldEx(IntPtr message, StringBuilder fieldName);
		[DllImport(dllName, CharSet = CharSet.Ansi, EntryPoint = "GetRepeatableNepField")]
		public static extern IntPtr GetRepeatableNepFieldEx(IntPtr message, StringBuilder fieldName, int index);

		[DllImport(dllName, CharSet = CharSet.Ansi, EntryPoint = "SetLogPath")]
		public static extern int SetLogPathEx(StringBuilder path);
		[DllImport(dllName, CharSet = CharSet.Ansi, EntryPoint = "SetLogLevel")]
		public static extern int SetLogLevelEx(int level);
		[DllImport(dllName, CharSet = CharSet.Ansi, EntryPoint = "SetLogFileSize")]
		public static extern int SetLogFileSizeEx(int maxSize);
		[DllImport(dllName, CharSet = CharSet.Ansi, EntryPoint = "SetLogFileCount")]
		public static extern int SetLogFileCountEx(int count);

		[DllImport(dllName, CharSet = CharSet.Ansi, EntryPoint = "GetEftComNumber")]
		public static extern int GetEftComNumberEx();
		#endregion

		#region types
		static class Tools
		{
			public static StringBuilder StringBuilder(string s) => default == s ? null : new StringBuilder(s);
		}
		#endregion

		#region constructor
		public CNepting() { Initialize(); }
		void Initialize()
		{
			Ready = false;
			Connected = false;
			_logpath = string.Empty;
		}
		#endregion

		#region constants
		const string NEPSA = "NEPTING - ";
		#endregion

		#region properties
		/// <summary>
		/// True if connected to Nepting terminal, false otherwise
		/// </summary>
		public bool Connected { get; private set; }
		//public string LogPath
		//{
		//	get => _logpath;
		//	set
		//	{
		//		if (!Connected)
		//		{
		//			IntPtr s = ExwternSetLogPath(HPDF_Font_GetFontName(handle);
		//			return Marshal.PtrToStringAnsi(s);
		//		}
		//		_logpath = Connected ? _logpath : SetLogPath}
		//}
		//public string _logpath = string.Empty;
		#endregion


		#region objects
		public class CNeptingField
		{
			public string Name;
			public string Value;
			public bool IsValid { get => !Name.IsNullOrEmpty() && !Value.IsNullOrEmpty(); }
		}
		public class CNeptingFields : List<CNeptingField>
		{
			public CNeptingFields() { }
			public CNeptingFields(IList<CNeptingField> fields) : base(fields) { }
		}
		public class CNeptingFieldsEx : ReadOnlyCollection<CNeptingField>
		{
			public CNeptingFieldsEx(IList<CNeptingField> fields) : base(fields) { }
		}

		public interface ICNeptingMessage
		{
			IntPtr Message { get; set; }
			bool Created { get; }
		}
		/// <summary>
		/// Generic Nepting message
		/// </summary>
		public class CNeptingMessage : ICNeptingMessage
		{
			public CNeptingMessage() { Initialize(); }
			public CNeptingMessage(CNeptingMessage msg) { Assign(msg); }
			~CNeptingMessage() { FreeNepMessage(); }

			public IntPtr Message { get; set; }
			public bool Created { get => default != Message; }

			/// <summary>
			/// Reset the whole message
			/// </summary>
			public virtual void Initialize() { Message = default; }
			/// <summary>
			/// Copy the content of a same message
			/// </summary>
			/// <param name="msg"></param>
			public virtual void Assign(ICNeptingMessage msg) { Initialize(); Message = msg.Message; }
			/// <summary>
			/// Create the message
			/// </summary>
			/// <returns>
			/// true if successfully, false otherwise
			/// </returns>
			public bool CreateNepMessage()
			{
				try
				{
					if (FreeNepMessage())
					{
						Message = CreateNepMessageEx();
						return true;
					}
				}
				catch (Exception ex)
				{
					CLog.EXCEPT(ex);
				}
				Message = default;
				return false;
			}
			/// <summary>
			/// Release the message
			/// </summary>
			/// <returns>
			/// true if successfully, false otherwise
			/// </returns>
			public bool FreeNepMessage()
			{
				try
				{
					if (Created && 0 < FreeNepMessageEx(Message))
					{
						Raz();
						return true;
					}
					CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingError, new object[] { MethodBase.GetCurrentMethod().Name })}");
				}
				catch (Exception ex)
				{
					CLog.EXCEPT(ex);
				}
				return false;
			}
			/// <summary>
			/// Get a field from a message
			/// </summary>
			/// <param name="method">Name of the method calling this function</param>
			/// <param name="fieldName">Name of the field to retrieve</param>
			/// <param name="index">The index of the field inside an array, if set below no index is used</param>
			/// <returns>
			/// A <see cref="CNeptingField"/> if successful, null otherwise
			/// </returns>
			CNeptingField GetXNepField(string method, string fieldName, int index = -1)
			{
				try
				{
					if (
						Created
						&& !fieldName.IsNullOrEmpty()
						)
					{
						string value =
							0 > index
							? GetNepFieldEx(Message, fieldName.StringBuilder()).IntPtrToStringAnsi()
							: GetRepeatableNepFieldEx(Message, fieldName.StringBuilder(), index).IntPtrToStringAnsi();

						if (value.IsNullOrEmpty())
						{
							return new CNeptingField() { Name = fieldName, Value = value };
						}
						else
						{
							if (0 > index)
								CLog.WARNING($"{NEPSA}{string.Format(Resources.CNeptingFieldNotPresent, new object[] { fieldName })}");
							else
								CLog.WARNING($"{NEPSA}{string.Format(Resources.CNeptingFieldIndexNotPresent, new object[] { fieldName, index })}");
						}
					}
					else
					{
						if (!Created)
							CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingNoMessage, new object[] { method })}");
						if (fieldName.IsNullOrEmpty())
							CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingNoFieldName, new object[] { })}");
					}
				}
				catch (Exception ex)
				{
					CLog.EXCEPT(ex);
				}
				return null;
			}
			/// <summary>
			/// Get a field from a message
			/// </summary>
			/// <param name="fieldName">Name of the field to retrieve</param>
			/// <returns>
			/// A <see cref="CNeptingField"/> if successful, null otherwise
			/// </returns>
			public CNeptingField GetNepField(string fieldName) => GetXNepField(MethodBase.GetCurrentMethod().Name, fieldName);
			/// <summary>
			/// Get a field by index from a message
			/// </summary>
			/// <param name="fieldName">Name of the field to retrieve</param>
			/// <param name="index">The index of the field inside an array</param>
			/// <returns>
			/// A <see cref="CNeptingField"/> if successful, null otherwise
			/// </returns>
			public CNeptingField GetRepeatableNepField(string fieldName, int index) => GetXNepField(MethodBase.GetCurrentMethod().Name, fieldName, index);
		}
		/// <summary>
		/// Generic Nepting message to send
		/// </summary>
		public class CNeptingMessageToSend : CNeptingMessage
		{
			public CNeptingMessageToSend() { Initialize(); }
			public CNeptingMessageToSend(CNeptingMessage msg) { Assign(msg); }

			public bool IsReady { get => Created && 0 != Fields.Count; }
			public CNeptingFieldsEx Fields { get; private set; }
			CNeptingFields fields = new CNeptingFields();

			/// <summary>
			/// Reset the whole message
			/// </summary>
			public override void Initialize()
			{
				base.Initialize();
				fields.Clear();
				Fields = new CNeptingFieldsEx(fields);
			}
			/// <summary>
			/// Copy the content of a same message
			/// </summary>
			/// <param name="msg"></param>
			public override void Assign(ICNeptingMessage msg)
			{
				base.Assign(msg);
				if (typeof(CNeptingMessageToSend) == msg.GetType())
				{
					fields = new CNeptingFields((msg as CNeptingMessageToSend).Fields);
				}
				else
				{
					fields = new CNeptingFields();
				}
				Fields = new CNeptingFieldsEx(fields);
			}
			/// <summary>indide the message
			/// </summary>
			/// <param name="fieldName">Field name to add</param>
			/// <param name="fieldValue">Field value</param>
			/// <returns>
			/// true if successfully, false otherwise
			/// </returns>
			public bool SetNepField(string fieldName, string fieldValue)
			{
				try
				{
					if (
						Created
						&& !fieldName.IsNullOrEmpty()
						&& !fieldValue.IsNullOrEmpty()
						)
					{
						CNeptingField field = new CNeptingField() { Name = fieldName, Value = fieldValue };
						fields.Add(field);
						if (0 < SetNepFieldEx(Message, field.Name.StringBuilder(), field.Value.StringBuilder()))
						{
							return true;
						}
						CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingError, new object[] { MethodBase.GetCurrentMethod().Name })}");
						fields.RemoveAt(fields.Count - 1);
					}
					else
					{
						if (!Created)
							CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingNoMessage, new object[] { MethodBase.GetCurrentMethod().Name })}");
						if (fieldName.IsNullOrEmpty())
							CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingNoFieldName, new object[] { })}");
						if (fieldValue.IsNullOrEmpty())
							CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingNoFieldValue, new object[] { fieldName })}");
					}
				}
				catch (Exception ex)
				{
					CLog.EXCEPT(ex);
				}
				return false;
			}
			public bool SetNepField(CNeptingField field) => SetNepField(field.Name, field.Value);
		}
		#endregion

#if AAAA
		#region nepting own messages
		public class CStringItem
		{
			#region constructor
			public CStringItem(int len, char padding = ' ') { Len = len; PaddingChar = padding; }
			#endregion

			#region properties
			[JsonIgnore]
			public string Value
			{
				get => GetValue(_value);
				set => _value = SetValue(value);
			}
			string _value = string.Empty;
			[JsonIgnore]
			public int ValueN
			{
				get { int.TryParse(Value, out int v); return v; }
				set { Value = Math.Abs(value).ToString(); }
			}

			protected virtual string GetValue(string value) => value;
			protected virtual string SetValue(string value)
			{
				if (value.IsNullOrEmpty()) value = string.Empty;
				value = value.Substring(0, Math.Min(Len, value.Length));
				if (value.Length < Len) value = new string(PaddingChar, Len - value.Length) + value;
				return value;
			}

			[JsonIgnore]
			public int Len { get; }
			[JsonIgnore]
			public char PaddingChar { get; }
			#endregion

			#region public methods
			public override string ToString() => Value;
			#endregion
		}
		public class CStringItemN : CStringItem { public CStringItemN(int len) : base(len, '0') { } }
		public interface IDataString
		{
			string Value { get; set; }
			int ValueAsInt { get; }
			bool Numeric { get; }
			bool Fixed { get; set; }
			bool Mandatory { get; set; }
			int Len { get; set; }
			int Minlen { get; set; }
		}
		public class CDataString : IDataString
		{
			public CDataString() { Numeric = false; Fixed = true; Mandatory = true; }
			public string Value
			{
				get => GetValue(_value);
				set => _value = SetValue(value);
			}
			string _value = string.Empty;

			protected virtual string GetValue(string value) => value;// (new CStringItem(Len, Numeric ? '0' : ' ') { Value = value }).Value;
			protected virtual string SetValue(string value)
			{
				int len = Fixed ? Len : (Len > value.Length ? (value.Length > Minlen ? value.Length : Minlen) : Len);
				return (Numeric ? (new CStringItemN(len) { Value = value }).Value : (new CStringItem(len) { Value = value }).Value);
			}

			[JsonIgnore]
			public int ValueAsInt
			{
				get
				{
					int.TryParse(Value, out int i);
					return i;
				}
			}
			[JsonIgnore]
			public bool Numeric { get; protected set; }
			[JsonIgnore]
			public bool Fixed { get; set; }
			[JsonIgnore]
			public bool Mandatory { get; set; }
			[JsonIgnore]
			public int Len { get => _len; set => _len = 1 > value ? _len : value; }
			int _len = 1;
			[JsonIgnore]
			public int Minlen { get => _minlen; set => _minlen = 0 > value ? _minlen : value; }
			int _minlen = 0;

			public override string ToString() => Value;
		}

		public class CRepeatableDataString : List<CDataString>
		{
			public CRepeatableDataString(CDataString ds) { DS = ds; }
			CDataString DS;
			public new void Add(CDataString ds)
			{
				DS.Value = ds.Value;
				base.Add(DS);
			}
			public override string ToString()
			{
				string s = string.Empty;
				foreach (CDataString k in this)
					s += k.ToString();
				return s;
			}
		}

		public class CNeptingHeader
		{
			public CDataString MESSAGE_NAME = new CDataString() { Fixed = false, Len = 12, Mandatory = true };
			public CDataString MESSAGE_TYPE = new CDataString() { Fixed = false, Len = 32, Mandatory = true };
			public override string ToString() => MESSAGE_NAME.ToString() + MESSAGE_TYPE.ToString();
		}

		public class CNeptingRepeatableDataN : List<CDataStringN>
		{
			public CNeptingRepeatableDataN(CDataStringN ds) { DS = ds; }
			CDataStringN DS;
			public new void Add(CDataStringN ds)
			{
				DS.Value = ds.Value;
				base.Add(DS);
			}
		}
		public class CNeptingLoginRequest : CNeptingHeader
		{
			public class CNeptingLoginRequestWebServiceUrl : List<CDataString>
			{

			}
			public CDataString MESSAGE_ID = new CDataString() { Fixed = false, Len = 9, Mandatory = true };
			public CDataString USER = new CDataString() { Fixed = false, Len = 64, Mandatory = false };
			public CDataString PASSWORD = new CDataString() { Fixed = false, Len = 32, Mandatory = false };
			public CRepeatableDataString WEB_SERVICE_URL = new CRepeatableDataString(new CDataString() { Fixed = false, Len = 32, Mandatory = false });
			public CDataString POS_NUMBER = new CDataString() { Numeric = true, Fixed = false, Len = 9, Mandatory = false };
			public CDataString EFT_NUMBER = new CDataString() { Numeric = true, Fixed = false, Len = 9, Mandatory = false };
			public CDataString POS_ALIAS = new CDataString() { Fixed = false, Len = 50, Mandatory = false };
			public CDataString CASHIER_ID = new CDataString() { Fixed = false, Len = 128, Mandatory = false };
			public CDataString TERMINAL_TYPE = new CDataString() { Numeric = true, Fixed = true, Len = 2, Mandatory = false };
			public CDataString UPDATE_ACTIVATED = new CDataString() { Numeric = true, Fixed = true, Len = 1, Mandatory = false };
			public CDataString LOAD_BALANCING_ALGO = new CDataString() { Numeric = true, Fixed = true, Len = 1, Mandatory = false };
			public override string ToString()
			{
				return base.ToString();
			}
		}
		public class CNeptingLoginResponse : CNeptingHeader
		{
			public CDataString MESSAGE_ID = new CDataString() { Fixed = false, Len = 9, Mandatory = true };
			public CDataStringN GLOBAL_STATUS = new CDataStringN() { Numeric = true, Fixed = false, Len = 1, Mandatory = true };
			public CRepeatableDataString EXTENDED_RESULT = new CRepeatableDataString(new CDataString() { Fixed = false, Len = 32, Mandatory = false });
			public CDataString WEB_SERVICE_URL = new CDataString() { Fixed = false, Len = 134, Mandatory = false };
			public CDataStringN MERCHANT_CODE = new CDataStringN() { Numeric = true, Fixed = false, Len = 32, Mandatory = false };
			public CDataStringN POS_NUMBER = new CDataStringN() { Numeric = true, Fixed = false, Len = 9, Mandatory = false };
			public CDataStringN EFT_NUMBER = new CDataStringN() { Numeric = true, Fixed = false, Len = 9, Mandatory = false };
			public CDataString POS_ALIAS = new CDataString() { Fixed = false, Len = 50, Mandatory = false };
			public CDataString CASHIER_ID = new CDataString() { Fixed = false, Len = 128, Mandatory = false };
			public CDataStringN TERMINAL_TYPE = new CDataStringN() { Fixed = true, Len = 2, Mandatory = false };
			public CDataStringN UPDATE_ACTIVATED = new CDataStringN() { Fixed = true, Len = 1, Mandatory = false };
			public CDataStringN LOAD_BALANCING_ALGO = new CDataStringN() { Fixed = true, Len = 1, Mandatory = false };
			public override string ToString()
			{
				return base.ToString();
			}
		}


		#endregion
#endif

		#region methods
		/// <summary>
		/// Initialise connection to Nepting terminal
		/// </summary>
		/// <param name="connectionType"></param>
		/// <returns>
		/// true if successfully, false otherwise
		/// </returns>
		public bool InitNepLib(string connectionType)
		{
			try
			{
				if (!Connected)
				{
					if (!(Connected = 0 < InitNepLibEx(connectionType.StringBuilder())))
						CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingError, new object[] { MethodBase.GetCurrentMethod().Name })}");
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			return false;
		}
		/// <summary>
		/// Close the Nepting environment
		/// </summary>
		/// <returns>
		/// true if successfully, false otherwise
		/// </returns>
		public bool CloseNepLib()
		{
			if (Connected)
				if (Connected = !(0 < CloseNepLibEx()))
					CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingError, new object[] { MethodBase.GetCurrentMethod().Name })}");
			return !Connected;
		}
		/// <summary>
		/// Send the Nepting message to the terminal
		/// </summary>
		/// <param name="msg">The <see cref="CNeptingMessageToSend"/> to send</param>
		/// <returns>
		/// true if successfully, false otherwise
		/// </returns>
		public bool SendNepMessage(CNeptingMessageToSend msg)
		{
			try
			{
				if (Connected
					&& default != msg
					&& msg.IsReady)
				{
					if (0 < SendNepMessageEx(msg.Message))
						return true;
					CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingError, new object[] { MethodBase.GetCurrentMethod().Name })}");
				}
				else
				{
					if (!Connected)
						CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingIsNotReady, new object[] { MethodBase.GetCurrentMethod().Name })}");
					if (default == msg || !msg.IsReady)
						CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingNoMessage, new object[] { })}");
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			return false;
		}
		/// <summary>
		/// Receives a message from a terminal
		/// </summary>
		/// <param name="timeout">Timout to wait for in milliseconds</param>
		/// <returns></returns>
		public CNeptingMessage ReceiveNepMessage(int timeout)
		{
			try
			{
				CNeptingMessage msg = new CNeptingMessage();
				if (Connected
					&& msg.CreateNepMessage())
				{
					int i = ReceiveNepMessageEx(msg.Message, timeout);
					if (0 < i)
					{
						return msg;
					}
					else if (0 == i)
					{
						CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingTimeoutReceiving, new object[] { MethodBase.GetCurrentMethod().Name })}");
					}
					else
					{
						CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingFailedCreatingMessage, new object[] { MethodBase.GetCurrentMethod().Name })}");
					}
				}
				else
				{
					if (!Connected)
						CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingIsNotReady, new object[] { MethodBase.GetCurrentMethod().Name })}");
					if (!msg.Created)
						CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingNoMessage, new object[] { })}");
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			return false;
		}

		/// <summary>
		/// Set Nepting log file
		/// </summary>
		/// <param name="path">Path to use for the log file</param>
		/// <returns>
		/// true if successfully, false otherwise
		/// </returns>
		public bool SetLogPath(string path)
		{
			try
			{
				if (!Connected && !CMisc.VerifyDirectory(path, false).IsNullOrEmpty())
				{
					if (0 < SetLogPathEx(path.StringBuilder()))
						return true;
					CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingError, new object[] { MethodBase.GetCurrentMethod().Name })}");
				}
				else
				{
					if (Connected)
						CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingIsReady, new object[] { MethodBase.GetCurrentMethod().Name })}");
					if (path.IsNullOrEmpty())
						CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingInvalidPath, new object[] { path })}");
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			return false;
		}
		/// <summary>
		/// Set the log level
		/// </summary>
		/// <param name="level">Level to set (between 0 and 5 included, 5 being most verbose)</param>
		/// <returns>
		/// true if successfully, false otherwise
		/// </returns>
		public bool SetLogLevel(int level)
		{
			try
			{
				if (!Connected && 0 <= level && level <= 5)
				{
					if (0 < SetLogLevelEx(level))
						return true;
					CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingError, new object[] { MethodBase.GetCurrentMethod().Name })}");
				}
				else
				{
					if (Connected)
						CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingIsReady, new object[] { MethodBase.GetCurrentMethod().Name })}");
					else
						CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingInvalidLogLevel, new object[] { level.ToString() })}");
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			return false;
		}
		/// <summary>
		/// Set log file size (can be up to 5Mb)
		/// </summary>
		/// <param name="maxSize">New size of the log file</param>
		/// <returns>
		/// true if successfully, false otherwise
		/// </returns>
		public bool SetLogFileSize(int maxSize)
		{
			try
			{
				if (!Connected && 0 < maxSize && maxSize <= 1024 * 1024 * 5)
				{
					if (0 < SetLogFileSizeEx(maxSize))
						return true;
					CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingError, new object[] { MethodBase.GetCurrentMethod().Name })}");
				}
				else
				{
					if (Connected)
						CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingIsReady, new object[] { MethodBase.GetCurrentMethod().Name })}");
					else
						CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingInvalidLogFileSize, new object[] { maxSize.ToString() })}");
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			return false;
		}
		/// <summary>
		/// Set the number of log files to keep
		/// </summary>
		/// <param name="count"></param>
		/// <returns>
		/// true if successfully, false otherwise
		/// </returns>
		public bool SetLogFileCount(int count)
		{
			try
			{
				if (!Connected)
				{
					if (0 < SetLogFileCountEx(count))
						return true;
					CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingError, new object[] { MethodBase.GetCurrentMethod().Name })}");
				}
				else
				{
					if (Connected)
						CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingIsReady, new object[] { MethodBase.GetCurrentMethod().Name })}");
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			return false;
		}
		/// <summary>
		/// Get the first COM port on which a Nepting terminal is connected to (if any)
		/// </summary>
		/// <param name="com">[REF] the COM port of the terminal it successful</param>
		/// <returns>
		/// true if successfully, false otherwise
		/// </returns>
		public bool GetEftComNumber(ref int com)
		{
			try
			{
				int i = GetEftComNumberEx();
				if (0 >= i)
				{
					CLog.ERROR($"{NEPSA}{string.Format(Resources.NeptingError, new object[] { MethodBase.GetCurrentMethod().Name })}");
					return false;
				}
				else
				{
					com = i;
					return true;
				}
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			return false;
		}
		#endregion
	}
}
