using System;
using System.Reflection;
using System.Net;
using System.Net.Sockets;
using COMMON;

namespace NEXO
{
	/// <summary>
	/// IP address of a client POS
	/// </summary>
	public class NexoEndPoint : NexoKey
	{
		#region constructor
		/// <summary>
		/// 
		/// </summary>
		/// <param name="client">TCP client for remote IP</param>
		public NexoEndPoint(TcpClient client)
		{
			IP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
			Initialise();
		}
		public NexoEndPoint(string ip)
		{
			IP = ip;
			Initialise();
		}
		private void Initialise()
		{
			Key = GetKey(this);
			Description = GetDescription();
		}
		#endregion

		#region properties
		/// <summary>
		/// IP address of remote end point
		/// </summary>
		public string IP { get; }
		/// <summary>
		/// All connections from this endpoint
		/// </summary>
		class Connection : NexoKey
		{
			public Connection(bool accepted)
			{
				Timestamp = DateTime.Now;
				Accepted = accepted;
				Key = Timestamp.ToString(Chars.DATETIMEEX);
				Description = "Connection";
			}
			public DateTime Timestamp { get; } = default;
			public bool Accepted { get; } = false;
			public override string ToString(bool addkey)
			{
				return ToString(addkey, (Accepted ? "Accepted" : "Denied") + (!addkey ? " at " + Key : null));
			}
		}
		class ListOfConnections : NexoListOfObjects<Connection>
		{
			public ListOfConnections() : base("ENDPOINT CONNECTIONS") { }
		}
		private ListOfConnections Connections = new ListOfConnections();
		#endregion

		#region methods
		public static string GetKey(NexoEndPoint o)
		{
			return o.IP.ToString();
		}
		public static string GetDescription()
		{
			return "IP";
		}
		public override string ToString(bool addkey)
		{
			return ToString(addkey, Connections.ToString());
		}
		/// <summary>
		/// Add a connection for that endpoint
		/// </summary>
		/// <param name="accepted"></param>
		/// <returns></returns>
		public bool AddConnection(bool accepted)
		{
			try
			{
				Connections.Add(new Connection(accepted));
				return true;
			}
			catch (Exception ex)
			{
				CLog.AddException(MethodBase.GetCurrentMethod().Name, ex);
			}
			return false;
		}
		#endregion
	}

	/// <summary>
	/// List of all endpoints for all POS
	/// </summary>
	public class NexoListOfEndPoints : NexoListOfObjects<NexoEndPoint>
	{
		public NexoListOfEndPoints(string text) : base(text) { }
	}

	/// <summary>
	/// List of all endpoints for all POS
	/// </summary>
	public class NexoDictionaryOfEndPoints : NexoDictionaryOfObjects<NexoEndPoint>
	{
		public NexoDictionaryOfEndPoints(string text) : base(text) { }
	}
}
