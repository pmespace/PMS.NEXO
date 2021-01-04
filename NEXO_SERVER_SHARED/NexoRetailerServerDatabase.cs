using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using COMMON;
using System.Net.Sockets;
using System.Net;

namespace NEXO.Server
{
	public class NexoRetailerServerDatabaseConnection
	{
		#region properties
		public string IP { get; set; }
		public string SaleID { get; set; }
		public string POIID { get; set; }
		public string LoginTimestamp { get; set; }
		public string LogoutTimestamp { get; set; }
		public bool Logged { get; set; }
		public string ManufacturerID { get; set; }
		public string ApplicationName { get; set; }
		public string SoftwareVersion { get; set; }
		public string CertificationCode { get; set; }
		public string AutoLogoutTimestamp { get; set; }
		#endregion

		#region constants
		public enum Labels
		{
			IP,
			SaleID,
			POIID,
			LoginTimestamp,
			LogoutTimestamp,
			Logged,
			ManufacturerID,
			ApplicationName,
			SoftwareVersion,
			CertificationCode,
			AutoLogoutTimestamp,
		}
		#endregion
	}

	public class NexoRetailerServerDatabaseEndPoint
	{
		#region properties
		public string IP { get; set; }
		public bool Accepted { get; set; }
		#endregion

		#region constants
		public enum Labels
		{
			IP,
			Accepted,
		}
		#endregion

		#region methods
		public override string ToString()
		{
			return $"{Labels.IP}: {IP}; {Labels.Accepted}: {Accepted}";
		}
		#endregion
	}

	public class NexoRetailerServerDatabaseSale
	{
		#region properties
		public string IP { get; set; }
		public string SaleID { get; set; }
		public bool Accepted { get; set; }
		public string CertificationCode { get; set; }
		#endregion

		#region constants
		public enum Labels
		{
			IP,
			SaleID,
			Accepted,
			CertificationCode,
		}
		#endregion

		#region methods
		public override string ToString()
		{
			return $"{Labels.IP}: {IP}; {Labels.SaleID}: {SaleID}; {Labels.CertificationCode}: {CertificationCode}; {Labels.Accepted}: {Accepted}";
		}
		#endregion
	}

	public class NexoRetailerServerDatabaseMessage
	{
		#region properties
		public int ID { get; set; }
		public string SaleID { get; set; }
		public string POIID { get; set; }
		public string Category { get; set; }
		public bool Received { get; set; }
		public string ServiceID { get; set; }
		public string DeviceID { get; set; }
		public string Request { get; set; }
		public string RequestTimestamp { get; set; }
		public string Reply { get; set; }
		public string ReplyTimestamp { get; set; }
		public string Result { get; set; }
		public string ErrorCondition { get; set; }
		public string AdditionalResponse { get; set; }
		public double RequestedAmount { get; set; }
		public double AuthorizedAmount { get; set; }
		public string TransactionCurrency { get; set; }
		public string ReconciliationID { get; set; }
		public string SaleTransactionID { get; set; }
		public string SaleTransactionTimestamp { get; set; }
		public string POITransactionID { get; set; }
		public string POITransactionTimestamp { get; set; }
		#endregion

		#region constants
		public enum Labels
		{
			ID,
			SaleID,
			POIID,
			Category,
			Received,
			ServiceID,
			DeviceID,
			Request,
			RequestTimestamp,
			Reply,
			ReplyTimestamp,
			Result,
			ErrorCondition,
			AdditionalResponse,
			RequestedAmount,
			AuthorizedAmount,
			TransactionCurrency,
			ReconciliationID,
			SaleTransactionID,
			SaleTransactionTimestamp,
			POITransactionID,
			POITransactionTimestamp,
		}
		#endregion
	}

	[Guid("B46DBE4F-C3E3-41F8-BFE8-E10DBEF1988B")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoRetailerServerDatabaseSettings
	{
		[DispId(1)]
		string ConnectionString { get; set; }
		[DispId(2)]
		string ConnectionsTableName { get; set; }
		[DispId(3)]
		string MessagesTableName { get; set; }
		[DispId(4)]
		string EndPointsTableName { get; set; }
		[DispId(5)]
		string SalesTableName { get; set; }
		[DispId(6)]
		bool DeclineByDefault { get; set; }
		[DispId(7)]
		bool Secured { get; set; }
		[DispId(8)]
		uint DelayBeforeAutoLogout { get; set; }

		[DispId(100)]
		bool IsValid();
	}
	[Guid("A01C5551-4413-42D9-9612-048ACAE918B1")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoRetailerServerDatabaseSettings : INexoRetailerServerDatabaseSettings
	{
		#region properties
		public string ConnectionString { get; set; }

		public string ConnectionsTableName
		{
			get => null != _connectionstablename ? _connectionstablename : "Connections";
			set => _connectionstablename = value;
		}
		private string _connectionstablename = null;

		public string MessagesTableName
		{
			get => null != _messagestablename ? _messagestablename : "Messages";
			set => _messagestablename = value;
		}
		private string _messagestablename = null;

		public string EndPointsTableName
		{
			get => null != _endpointstablename ? _endpointstablename : "EndPoints";
			set => _endpointstablename = value;
		}
		private string _endpointstablename = null;

		public string SalesTableName
		{
			get => null != _salestablename ? _salestablename : "Sales";
			set => _salestablename = value;
		}
		private string _salestablename = null;
		/// <summary>
		/// True => granted access must be explicit (either explicitely or generically) otherwise access is declined
		/// False => declined access must be explicit (either explicitely or generically) otherwise access is granted
		/// That flag is superseded by <see cref="Secured"/> which applies maximum security
		/// </summary>
		public bool DeclineByDefault { get; set; } = true;
		/// <summary>
		/// True means maximum security is ensured meaning: an entity can connect if not declined (either explicitely or generically) and granted (either explicitely or generically); if one is missing the request is declined
		/// False means <see cref="DeclineByDefault"/> applies
		/// </summary>
		public bool Secured { get; set; } = true;
		/// <summary>
		/// Delay before autologout, expressed in minutes
		/// </summary>
		public uint DelayBeforeAutoLogout { get; set; } = DEFAULT_DELAY_BEFORE_AUTO_LOGOUT;
		public static uint DEFAULT_DELAY_BEFORE_AUTO_LOGOUT = 120; /* 2 hours */
		#endregion

		#region methods
		public bool IsValid() { return !string.IsNullOrEmpty(ConnectionString); }
		#endregion
	}

	/// <summary>
	/// Settings inside a JSON file to efficiently use a database
	/// </summary>
	public class NexoRetailerServerDatabase : CDatabase
	{
		#region constructor
		public NexoRetailerServerDatabase() { }
		~NexoRetailerServerDatabase() { ConnectionString = null; }
		#endregion

		#region properties
		public NexoRetailerServerDatabaseSettings Settings
		{
			get => _settings;
			internal set
			{
				if (null != value)
				{
					ConnectionString = value.ConnectionString;
					if (IsOpen)
					{
						_settings = value;
					}
				}
				else
					ConnectionString = null;
			}
		}
		private NexoRetailerServerDatabaseSettings _settings = null;
		#endregion

		#region constants
		public static string GENERIC = "'*'";
		public static string REPLACEIT = "%1";
		#endregion

		#region methods
		private string IPFullAddress(TcpClient tcp) { return tcp.Client.RemoteEndPoint.ToString(); }
		private string IPAddress(TcpClient tcp) { return ((IPEndPoint)tcp.Client.RemoteEndPoint).Address.ToString(); }
		private string IPPort(TcpClient tcp) { return ((IPEndPoint)tcp.Client.RemoteEndPoint).Port.ToString(); }
		private string StringOrNull(string s)
		{
			if (string.IsNullOrEmpty(s))
				return "NULL";
			return $"'{s}'";
		}
		private string TestStringOrNull(string s)
		{
			if (string.IsNullOrEmpty(s))
				return " IS NULL";
			return $"='{s}'";
		}
		private string SafeString(string s)
		{
			// makes every single quote a double quote
			if (!string.IsNullOrEmpty(s))
				return s.Replace(@"'", @"''");
			return null;
		}
		private bool IsDeclined<TxN>(string sql, FeedRecordDelegate fnc)
		{
			string sqlx = sql.Replace(REPLACEIT, FALSE());
			List<TxN> list = SelectRequest<TxN>(sqlx, fnc);
			bool fOK = (null != list && 0 != list.Count);
			string rules = null;
			if (fOK)
				foreach (TxN txn in list)
					rules += txn.ToString() + "; ";
			CLog.Add($"Secured: {Settings.Secured}; Default to decline: {Settings.DeclineByDefault} - " + (fOK ? $"Access declined [{sqlx}] by {list.Count} rules [{rules}]" : $"Access not declined [{sqlx}]"), fOK ? TLog.WARNG : TLog.INFOR);
			return fOK;
		}
		private bool IsGranted<TxN>(string sql, FeedRecordDelegate fnc)
		{
			string sqlx = sql.Replace(REPLACEIT, TRUE());
			List<TxN> list = SelectRequest<TxN>(sqlx, fnc);
			bool fOK = (null != list && 0 != list.Count);
			string rules = null;
			if (fOK)
				foreach (TxN txn in list)
					rules += txn.ToString() + "; ";
			CLog.Add((fOK ? $"Access granted [{sqlx}] by {list.Count} rules [{rules}]" : $"Access not granted [{sqlx}]"), fOK ? TLog.INFOR : TLog.WARNG);
			return fOK;
		}
		public bool CloseAllConnections()
		{
			if (!IsOpen) return false;

			DateTime dt = DateTime.Now;
			string s = dt.ToString(Chars.DATETIME);

			// keep track of the unsuccessfull connection attempt
			string sql = $"UPDATE {Settings.ConnectionsTableName} SET " +
				$"{NexoRetailerServerDatabaseConnection.Labels.LogoutTimestamp}='{s}'" +
				"WHERE " +
				$"{NexoRetailerServerDatabaseConnection.Labels.Logged}={TRUE()}";
			int nbRows = 0;
			if (NonSelectRequest(sql, ref nbRows))
				return true;
			return false;
		}
		/// <summary>
		/// Determine whether an IP is accepted to connect to the server
		/// </summary>
		/// <param name="tcp">IP to look for</param>
		/// <param name="logit">If true a failed connection will be logged if not accepted</param>
		/// <returns>True if access is granted, false otherwise</returns>
		public bool IsEndPointAccepted(TcpClient tcp, bool logit = true)
		{
			bool fOK = false;
			if (!IsOpen) return false;
			List<NexoRetailerServerDatabaseEndPoint> list;

			string sql = $"SELECT * FROM {Settings.EndPointsTableName} WHERE " +
				$"({NexoRetailerServerDatabaseEndPoint.Labels.IP}='{IPAddress(tcp)}' OR {NexoRetailerServerDatabaseEndPoint.Labels.IP}={GENERIC}) AND " +
				$"{NexoRetailerServerDatabaseEndPoint.Labels.Accepted}={REPLACEIT}";

			if (Settings.Secured)
			{
				fOK = !IsDeclined<NexoRetailerServerDatabaseEndPoint>(sql, FeedEndPoint) && IsGranted<NexoRetailerServerDatabaseEndPoint>(sql, FeedEndPoint);
			}
			else if (Settings.DeclineByDefault)
			{
				fOK = IsGranted<NexoRetailerServerDatabaseEndPoint>(sql, FeedEndPoint);
			}
			else
			{
				fOK = !IsDeclined<NexoRetailerServerDatabaseEndPoint>(sql, FeedEndPoint);
			}
			if (fOK) return true;
			// arrived here the EndPoint is not accepted, eventually log unsuccessfull connection attemps
			if (logit)
			{
				DateTime dt = new DateTime();
				AddConnectionEx(tcp, null, null, false, new TimeSpan(0), out dt);
			}
			return fOK;
		}
		private NexoRetailerServerDatabaseEndPoint FeedEndPoint(OleDbDataReader reader)
		{
			NexoRetailerServerDatabaseEndPoint endPoint = new NexoRetailerServerDatabaseEndPoint();
			try
			{
				bool b = false;
				string s = null;
				if (CDatabase.ItemValue<string>(reader, NexoRetailerServerDatabaseEndPoint.Labels.IP.ToString(), ref s))
					endPoint.IP = s;
				else if (CDatabase.ItemValue<bool>(reader, NexoRetailerServerDatabaseEndPoint.Labels.Accepted.ToString(), ref b))
					endPoint.Accepted = b;
				return endPoint;
			}
			catch (Exception) { }
			return null;
		}
		/// <summary>
		/// Determine whether a Sale is accepted to connect to the server
		/// </summary>
		/// <param name="tcp">IP to look for</param>
		/// <param name="nxo">A <see cref="NexoLogin"/> object</param>
		/// <param name="logit">If true a failed connection will be logged if not accepted</param>
		/// <returns>True if access is granted, false otherwise</returns>
		public bool IsSaleIDAccepted(TcpClient tcp, NexoLogin nxo, bool logit = true)
		{
			bool fOK;
			if (!IsOpen) return false;
			List<NexoRetailerServerDatabaseSale> list;

			string sql = $"SELECT * FROM {Settings.SalesTableName}" +
				" WHERE " +
				$"({NexoRetailerServerDatabaseSale.Labels.SaleID}='{nxo.SaleID}' OR {NexoRetailerServerDatabaseSale.Labels.SaleID}={GENERIC}) AND " +
				$"({NexoRetailerServerDatabaseSale.Labels.IP}='{IPAddress(tcp)}' OR {NexoRetailerServerDatabaseSale.Labels.IP}={GENERIC}) AND " +
				$"({NexoRetailerServerDatabaseSale.Labels.CertificationCode}='{nxo.RequestCertificationCode}' OR {NexoRetailerServerDatabaseSale.Labels.CertificationCode}={GENERIC}) AND " +
				$"{NexoRetailerServerDatabaseSale.Labels.Accepted}={REPLACEIT}";

			if (Settings.Secured)
			{
				fOK = !IsDeclined<NexoRetailerServerDatabaseSale>(sql, FeedSale) && IsGranted<NexoRetailerServerDatabaseSale>(sql, FeedSale);
			}
			else if (Settings.DeclineByDefault)
			{
				fOK = IsGranted<NexoRetailerServerDatabaseSale>(sql, FeedSale);
			}
			else
			{
				fOK = !IsDeclined<NexoRetailerServerDatabaseSale>(sql, FeedSale);
			}
			if (fOK) return true;
			// arrived here the sale is not accepted, eventually log unsuccessfull connection attemps
			if (logit)
			{
				DateTime dt = new DateTime();
				AddConnectionEx(tcp, nxo.SaleID, nxo, false, new TimeSpan(0), out dt);
			}
			return fOK;
		}
		private NexoRetailerServerDatabaseSale FeedSale(OleDbDataReader reader)
		{
			NexoRetailerServerDatabaseSale sale = new NexoRetailerServerDatabaseSale();
			try
			{
				bool b = false;
				string s = null;
				if (CDatabase.ItemValue<string>(reader, NexoRetailerServerDatabaseSale.Labels.IP.ToString(), ref s))
					sale.IP = s;
				else if (CDatabase.ItemValue<string>(reader, NexoRetailerServerDatabaseSale.Labels.SaleID.ToString(), ref s))
					sale.SaleID = s;
				else if (CDatabase.ItemValue<bool>(reader, NexoRetailerServerDatabaseSale.Labels.Accepted.ToString(), ref b))
					sale.Accepted = b;
				else if (CDatabase.ItemValue<string>(reader, NexoRetailerServerDatabaseSale.Labels.CertificationCode.ToString(), ref s))
					sale.CertificationCode = s;
				return sale;
			}
			catch (Exception) { }
			return null;
		}
		/// <summary>
		/// Add a successfull connection
		/// </summary>
		/// <param name="tcp">Originating IP</param>
		/// <param name="nxo">A <see cref="NexoLogin"/> object to use if connection is successfull</param>
		/// <param name="accepted">True if the connection is accepted, false otherwise. If nxo is null the connection is always considered declined</param>
		/// <param name="delay">Number of minutes before auto logout without any message</param>
		/// <param name="logout">[out] a <see cref="DateTime"/> object describing when the connection will be automatically closed without activity</param>
		/// <returns>True if successfull, false otherwise</returns>
		public bool AddConnection(TcpClient tcp, NexoLogin nxo, bool accepted, TimeSpan delay, out DateTime logout)
		{
			logout = default;
			if (!IsOpen) return false;
			if (null == nxo) return false;
			return AddConnectionEx(tcp, nxo.SaleID, nxo, accepted, delay, out logout);
		}
		private bool AddConnectionEx(TcpClient tcp, string saleid, NexoLogin nxo, bool accepted, TimeSpan delay, out DateTime logout)
		{
			logout = default;
			if (!IsOpen) return false;
			if (accepted && null == nxo) return false;

			DateTime dt = DateTime.Now;
			string s = dt.ToString(Chars.DATETIME);
			DateTime dtx = dt.Add(delay);
			string sx = dtx.ToString(Chars.DATETIME);

			string sql = $"INSERT INTO {Settings.ConnectionsTableName} (" +
				$"{NexoRetailerServerDatabaseConnection.Labels.IP}, {NexoRetailerServerDatabaseConnection.Labels.SaleID}" +
				$", {NexoRetailerServerDatabaseConnection.Labels.Logged}" +
				$", {NexoRetailerServerDatabaseConnection.Labels.LoginTimestamp}, {NexoRetailerServerDatabaseConnection.Labels.AutoLogoutTimestamp} " +
				(null != nxo ? $", {NexoRetailerServerDatabaseConnection.Labels.POIID}, {NexoRetailerServerDatabaseConnection.Labels.SoftwareVersion}, {NexoRetailerServerDatabaseConnection.Labels.ApplicationName}, {NexoRetailerServerDatabaseConnection.Labels.CertificationCode}, {NexoRetailerServerDatabaseConnection.Labels.ManufacturerID} " : null) +
				$") VALUES (" +
				$"'{IPAddress(tcp)}', '{saleid}', " +
				(accepted ? $"{TRUE()}, " : $"{FALSE()}, ") +
				$"'{s}', '{sx}' " +
				(null != nxo ? $", '{nxo.POIID}', {StringOrNull(nxo.RequestSoftwareVersion)}, {StringOrNull(nxo.RequestApplicationName)}, {StringOrNull(nxo.RequestCertificationCode)}, {StringOrNull(nxo.RequestManufacturerID)} " : null) +
				$")";

			int nbRows = 0;
			if (NonSelectRequest(sql, ref nbRows))
			{
				logout = dtx;
				return true;
			}
			return false;
		}
		/// <summary>
		/// Set a connection as closed
		/// </summary>
		/// <param name="tcp">Originating IP</param>
		/// <param name="nxo">A <see cref="NexoLogout"/> object to use if disconnection is successfull</param>
		/// <param name="logout">[out] The logout datetime if successfull, a default <see cref="DateTime"/> object otherwise</param>
		/// <returns>True if successfull (disconnected), false otherwise (not disconnected, does not exist,...)</returns>
		public bool SetDisconnected(TcpClient tcp, NexoLogout nxo, out DateTime logout)
		{
			logout = default;
			if (!IsOpen) return false;
			if (null == nxo) return false;

			DateTime dt = DateTime.Now;
			string s = dt.ToString(Chars.DATETIME);

			// keep track of the unsuccessfull connection attempt
			string sql = $"UPDATE {Settings.ConnectionsTableName} SET " +
				$"{NexoRetailerServerDatabaseConnection.Labels.LogoutTimestamp}='{s}'" +
				"WHERE " +
				$"{NexoRetailerServerDatabaseConnection.Labels.IP}='{IPAddress(tcp)}' AND " +
				$"{NexoRetailerServerDatabaseConnection.Labels.SaleID}='{nxo.SaleID}' AND " +
				$"{NexoRetailerServerDatabaseConnection.Labels.POIID}='{nxo.POIID}' AND " +
				$"{NexoRetailerServerDatabaseConnection.Labels.Logged}={TRUE()}";

			int nbRows = 0;
			if (NonSelectRequest(sql, ref nbRows))
				return true;
			return false;
		}
		/// <summary>
		/// Assert whether a saleis connected to the server
		/// </summary>
		/// <param name="tcp">Originating IP</param>
		/// <param name="saleid">Originating SaleID</param>
		/// <param name="poiid">Connected POIID</param>
		/// <param name="delay">If Connected POIID</param>
		/// <param name="logout">[out] The logout datetime if successfull, a default <see cref="DateTime"/> object otherwise</param>
		/// <returns>True if connected, false otherwise</returns>
		public bool IsSaleIDConnected(TcpClient tcp, string saleid, string poiid, TimeSpan delay, out DateTime logout)
		{
			logout = default;
			if (!IsOpen) return false;

			DateTime dt = DateTime.Now;
			string s = dt.ToString(Chars.DATETIME);
			DateTime dtx = dt.Add(delay);
			string sx = dtx.ToString(Chars.DATETIME);

			string sql = $"UPDATE {Settings.ConnectionsTableName} SET " +
				$"{NexoRetailerServerDatabaseConnection.Labels.AutoLogoutTimestamp}='{sx}' " +
				"WHERE " +
				$"{NexoRetailerServerDatabaseConnection.Labels.IP}='{IPAddress(tcp)}' AND " +
				$"{NexoRetailerServerDatabaseConnection.Labels.SaleID}='{saleid}' AND " +
				$"{NexoRetailerServerDatabaseConnection.Labels.POIID}='{poiid}' AND " +
				$"{NexoRetailerServerDatabaseConnection.Labels.Logged}={TRUE()} AND " +
				$"{NexoRetailerServerDatabaseConnection.Labels.LogoutTimestamp}=NULL AND " +
				$"{NexoRetailerServerDatabaseConnection.Labels.AutoLogoutTimestamp}>='{s}')";

			// is access granted ?
			int nbRows = 0;
			if (NonSelectRequest(sql, ref nbRows) && 0 != nbRows)
			{
				logout = dtx;
				return true;
			}
			else
			{
				// no access granted, set all matching (but AutoLogoutTimestamp) instances to disconnected
				sql = $"UPDATE {Settings.ConnectionsTableName} SET " +
					$"{NexoRetailerServerDatabaseConnection.Labels.LogoutTimestamp}='{NexoRetailerServerDatabaseConnection.Labels.AutoLogoutTimestamp}' " +
					"WHERE " +
					$"{NexoRetailerServerDatabaseConnection.Labels.IP}='{IPAddress(tcp)}' AND {NexoRetailerServerDatabaseConnection.Labels.SaleID}='{saleid}' AND {NexoRetailerServerDatabaseConnection.Labels.POIID}='{poiid}' AND {NexoRetailerServerDatabaseConnection.Labels.Logged}={TRUE()} AND {NexoRetailerServerDatabaseConnection.Labels.LogoutTimestamp}=NULL)";
				NonSelectRequest(sql, ref nbRows);
			}
			return false;
		}
		/// <summary>
		/// Add a new request message
		/// </summary>
		/// <param name="item">The message to add to the database</param>
		/// <param name="id">[out] the ID of the message to use for the update</param>
		/// <returns>True if added successfully and the ID has been returned, false otherwise</returns>
		public bool AddNewRequest(NexoItem item, out long id)
		{
			id = 0;
			if (!IsOpen) return false;

			DateTime dt = DateTime.Now;
			string s = dt.ToString(Chars.DATETIME);

			bool fOK = null != item && null != item.Item && item.Item.GetType() == typeof(SaleToPOIRequest);
			if (fOK)
			{
				// it is a valid request
				NexoDateTime ndt = new NexoDateTime();
				SaleToPOIRequest saletopoi = (SaleToPOIRequest)item.Item;
				PaymentRequestType payment = new PaymentRequestType();
				ReconciliationRequestType reconciliation = new ReconciliationRequestType();
				bool fPayment = saletopoi.Item.GetType() == typeof(PaymentRequestType);
				if (fPayment)
				{
					payment = (PaymentRequestType)saletopoi.Item;
					ndt.FromDateTime(new DateTime());
				}
				bool fReconciliation = saletopoi.Item.GetType() == typeof(ReconciliationRequestType);
				if (fReconciliation)
					reconciliation = (ReconciliationRequestType)saletopoi.Item;

				string sql = $"INSERT INTO {Settings.MessagesTableName} (" +
					$"{NexoRetailerServerDatabaseMessage.Labels.SaleID}" +
					$", {NexoRetailerServerDatabaseMessage.Labels.POIID}" +
					$", {NexoRetailerServerDatabaseMessage.Labels.Category}" +
					$", {NexoRetailerServerDatabaseMessage.Labels.Received}" +
					$", {NexoRetailerServerDatabaseMessage.Labels.ServiceID}" +
					$", {NexoRetailerServerDatabaseMessage.Labels.DeviceID}" +
					$", {NexoRetailerServerDatabaseMessage.Labels.Request}" +
					$", {NexoRetailerServerDatabaseMessage.Labels.RequestTimestamp}" +
					(fPayment ?
						$", {NexoRetailerServerDatabaseMessage.Labels.RequestedAmount}" +
						$", {NexoRetailerServerDatabaseMessage.Labels.TransactionCurrency}" +
						$", {NexoRetailerServerDatabaseMessage.Labels.SaleTransactionID}" +
						$", {NexoRetailerServerDatabaseMessage.Labels.SaleTransactionTimestamp}"
						: null) +
					$") VALUES (" +
					$"{StringOrNull(saletopoi.MessageHeader.SaleID)}" +
					$", {StringOrNull(saletopoi.MessageHeader.POIID)}" +
					$", {StringOrNull(saletopoi.MessageHeader.MessageCategory)}" +
					$", {TRUE()}" +
					$", {StringOrNull(saletopoi.MessageHeader.ServiceID)}" +
					$", {StringOrNull(saletopoi.MessageHeader.DeviceID)}" +
					$", {StringOrNull(SafeString(item.XML))}" +
					$", {StringOrNull(s)}" +
					(fPayment ?
						$", {StringOrNull(payment.PaymentTransaction.AmountsReq.RequestedAmount.ToString())}" +
						$", {StringOrNull(payment.PaymentTransaction.AmountsReq.Currency)}" +
						$", {StringOrNull(payment.SaleData.SaleTransactionID.TransactionID)}" +
						$", {StringOrNull(payment.SaleData.SaleTransactionID.TimeStamp)}"
						: null) +
						")";

				int nbRows = 0;
				if (NonSelectRequest(sql, ref nbRows) && 0 != nbRows)
				{
					// get message id
					sql = $"SELECT * FROM {Settings.MessagesTableName} WHERE " +
						$"{NexoRetailerServerDatabaseMessage.Labels.SaleID}='{saletopoi.MessageHeader.SaleID}' AND " +
						$"{NexoRetailerServerDatabaseMessage.Labels.POIID}='{saletopoi.MessageHeader.POIID}' AND " +
						$"{NexoRetailerServerDatabaseMessage.Labels.Category}='{saletopoi.MessageHeader.MessageCategory}' AND " +
						$"{NexoRetailerServerDatabaseMessage.Labels.Received}={TRUE()} AND " +
						$"{NexoRetailerServerDatabaseMessage.Labels.ServiceID}{TestStringOrNull(saletopoi.MessageHeader.ServiceID)} AND " +
						$"{NexoRetailerServerDatabaseMessage.Labels.DeviceID}{TestStringOrNull(saletopoi.MessageHeader.DeviceID)} AND " +
						$"{NexoRetailerServerDatabaseMessage.Labels.RequestTimestamp}='{s}'";
					List<NexoRetailerServerDatabaseMessage> list = SelectRequest<NexoRetailerServerDatabaseMessage>(sql, FeedMessage);
					if (null != list && 0 != list.Count)
					{
						id = list[0].ID;
					}
					return true;
				}
			}
			return false;
		}
		public bool SetRequestReply(long id, NexoItem item, ResponseType response)
		{
			if (!IsOpen) return false;

			DateTime dt = DateTime.Now;
			string s = dt.ToString(Chars.DATETIME);

			bool fOK = null != item && null != item.Item && item.Item.GetType() == typeof(SaleToPOIResponse);
			if (fOK)
			{
				// it is a valid request
				SaleToPOIResponse saletopoi = (SaleToPOIResponse)item.Item;
				PaymentResponseType payment = new PaymentResponseType();
				ReconciliationResponseType reconciliation = new ReconciliationResponseType();
				bool fPayment = saletopoi.Item.GetType() == typeof(PaymentResponseType);
				if (fPayment)
					payment = (PaymentResponseType)saletopoi.Item;
				bool fReconciliation = saletopoi.Item.GetType() == typeof(ReconciliationResponseType);
				if (fReconciliation)
					reconciliation = (ReconciliationResponseType)saletopoi.Item;

				string sql = $"UPDATE {Settings.MessagesTableName} SET " +
					$"{NexoRetailerServerDatabaseMessage.Labels.ReplyTimestamp}='{s}'" +
					$", {NexoRetailerServerDatabaseMessage.Labels.Reply}={StringOrNull(SafeString(item.XML))}" +
					$", {NexoRetailerServerDatabaseMessage.Labels.Result}={(null != response ? StringOrNull(response.Result) : null)}" +
					$", {NexoRetailerServerDatabaseMessage.Labels.ErrorCondition}={(null != response ? StringOrNull(response.ErrorCondition) : null)}" +
					$", {NexoRetailerServerDatabaseMessage.Labels.AdditionalResponse}={(null != response ? StringOrNull(SafeString(response.AdditionalResponse)) : null)}" +
					(fPayment ?
						$", {NexoRetailerServerDatabaseMessage.Labels.AuthorizedAmount}='{payment.PaymentResult.AmountsResp.AuthorizedAmount}'" +
						$", {NexoRetailerServerDatabaseMessage.Labels.POITransactionID}='{payment.POIData.POITransactionID.TransactionID}'" +
						$", {NexoRetailerServerDatabaseMessage.Labels.POITransactionTimestamp}='{payment.POIData.POITransactionID.TimeStamp}'"
						: null) +
					" WHERE " +
					$"{NexoRetailerServerDatabaseMessage.Labels.ID}={id}";

				int nbRows = 0;
				if (NonSelectRequest(sql, ref nbRows) && 0 != nbRows)
				{
					return true;
				}
			}
			return false;
		}
		private NexoRetailerServerDatabaseMessage FeedMessage(OleDbDataReader reader)
		{
			NexoRetailerServerDatabaseMessage msg = new NexoRetailerServerDatabaseMessage();
			try
			{
				int l = 0;
				if (CDatabase.ItemValue<int>(reader, NexoRetailerServerDatabaseMessage.Labels.ID.ToString(), ref l))
					msg.ID = l;
				return msg;
			}
			catch (Exception) { }
			return null;
		}
		#endregion
	}
}
