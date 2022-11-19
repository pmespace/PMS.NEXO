using System.Runtime.InteropServices;
using System;
using System.Reflection;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using COMMON;
using NEXO;

namespace NEXO
{
	/// <summary>
	/// A client is a currently connected to the server POS (sale)
	/// </summary>
	public class NexoPartner : NexoKey
	{
		#region constructor
		public NexoPartner(TcpClient tcp, MessageHeaderType mh)
		{
			SaleID = new NexoSaleID(CMisc.AsString(mh.SaleID));
			POIID = new NexoPOIID(CMisc.AsString(mh.POIID));
			EndPoint = new NexoEndPoint(tcp);

			_sessions = new NexoListOfSessions("SESSIONS");
			_messages = new NexoDictionaryOfMessages();

			Sessions = new ReadOnlyCollection<NexoSession>(_sessions);

#if NET45_OR_GREATER
			Messages = new ReadOnlyDictionary<string, NexoMessage>(_messages);
#else
			Messages = _messages;
#endif

			Timestamp = DateTime.Now;
			Key = GetKey(this);
			Description = GetDescription();
		}
		#endregion

		#region properties
		/// <summary>
		/// Cleint remote end point
		/// </summary>
		public NexoEndPoint EndPoint { get; }
		/// <summary>
		/// client SaleID
		/// </summary>
		public NexoSaleID SaleID { get; }
		/// <summary>
		/// client POIID
		/// </summary>
		public NexoPOIID POIID { get; }
		/// <summary>
		/// client connection time
		/// </summary>
		public DateTime Timestamp { get; }
		/// <summary>
		/// Indicates whether the partner is currently connected or not
		/// </summary>
		public bool Connected { get => 0 == Sessions.Count ? false : Sessions[Sessions.Count - 1].Connected; }

		/// <summary>
		/// all connections originating from this client
		/// </summary>
		public ReadOnlyCollection<NexoSession> Sessions { get; private set; }
#if NET45_OR_GREATER
		/// <summary>
		/// all messages exchanged with this client
		/// </summary>
		public ReadOnlyDictionary<string, NexoMessage> Messages { get; private set; }
#else
		///// <summary>
		///// all connections originating from this client
		///// </summary>
		//public NexoListOfSessions Sessions { get => _sessions; private set => _sessions = value; }
		/// <summary>
		/// all messages exchanged with this client
		/// </summary>
		public NexoDictionaryOfMessages Messages { get => _messages; private set => _messages = value; }
#endif

		private NexoDictionaryOfMessages _messages { get; set; }
		private NexoListOfSessions _sessions { get; set; }

		/// <summary>
		/// Current connection for that client
		/// </summary>
		/// <returns>The inserted <see cref="NexoSession"/> object if available, null otherwise</returns>
		public NexoSession CurrentConnection
		{
			get
			{
				try
				{
					if (0 != Sessions.Count)
						return Sessions[Sessions.Count - 1];
				}
				catch (Exception) { }
				return null;
			}
		}
		#endregion

		#region methods
		public static string GetKey(NexoPartner o)
		{
			return o.SaleID.Value
				+ "." + o.POIID.Value
				+ "@" + o.EndPoint.Key;
		}
		public static string GetDescription()
		{
			return "Client";
		}
		public override string ToString(bool addkey)
		{
			return ToString(addkey, null != CurrentConnection ? CurrentConnection.ToString(false) : "Not yet connected");
		}
		/// <summary>
		/// Add a new session for the partner
		/// </summary>
		/// <param name="session"></param>
		/// <returns></returns>
		public NexoSession AddSession(NexoSession session)
		{
			try
			{
				_sessions.Add(session);
				return LastSession();
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			return null;
		}
		/// <summary>
		/// Get the last session for the partner
		/// </summary>
		/// <returns></returns>
		public NexoSession LastSession()
		{
			try
			{
				return _sessions[_sessions.Count - 1];
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			return null;
		}
		///// <summary>
		///// Indicate a partner requested connection (Login) and it has been granted
		///// </summary>
		///// <param name="accepted"></param>
		///// <returns></returns>
		//public bool SetConnected(bool accepted)
		//{
		//	// get last connection event from stack
		//	try
		//	{
		//		// sale is being connected
		//		NexoSession session;
		//		if (0 == _sessions.Count)
		//		{
		//			// create a first connection 
		//			_sessions.Add(session = new NexoSession(this));
		//		}
		//		else
		//			session = _sessions[_sessions.Count - 1];

		//		// access to the last session
		//		if (session.Connected)
		//		{
		//			// already connected, nothing to do
		//			return true;
		//		}
		//		else
		//		{
		//			// disconnected, create a new connection
		//			session.SetConnected();
		//			_sessions.Add(session);
		//			return true;
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		CLog.EXCEPT(ex);
		//	}
		//	return false;
		//}
		///// <summary>
		///// Indicate a partner requested disconnection (Logout) 
		///// </summary>
		///// <returns></returns>
		//public bool SetDisconnected()
		//{
		//	// get last connection event from stack
		//	try
		//	{
		//		if (connected)
		//		{
		//			// sale is being connected
		//			NexoSession connection = new NexoSession(this);
		//			if (0 == _sessions.Count)
		//			{
		//				// create a first connection 
		//				_sessions.Add(connection);
		//				return true;
		//			}
		//			// access to the last connection
		//			if (_sessions[_sessions.Count - 1].Connected)
		//			{
		//				// already connected, nothing to do
		//				return true;
		//			}
		//			else
		//			{
		//				// disconnected, create a new connection
		//				_sessions.Add(connection);
		//				return true;
		//			}
		//		}
		//		else
		//		{
		//			// sale is being disconnected
		//			if (0 == _sessions.Count)
		//			{
		//				// no connection, nothing to do
		//				return true;
		//			}
		//			else
		//			{
		//				if (_sessions[_sessions.Count - 1].Connected)
		//				{
		//					// disconnect the sale
		//					return _sessions[_sessions.Count - 1].SetDisconnected();
		//				}
		//				else
		//				{
		//					// already disconnected, do nothing
		//					return true;
		//				}
		//			}
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		CLog.EXCEPT(ex);
		//	}
		//	return false;
		//}
		/// <summary>
		/// Add a message sent or received from or by the partner
		/// </summary>
		/// <param name="o"></param>
		/// <returns></returns>
		public NexoMessage AddMessage(NexoMessage o)
		{
			try
			{
				_messages.Add(o.Key, o);
				return _messages[o.Key];
			}
			catch (Exception ex)
			{
				CLog.EXCEPT(ex);
			}
			return null;
		}
		#endregion
	}

	/// <summary>
	/// List of all clients currently connected to the server
	/// Disconnected POS (sale) are no longer inside this list
	/// </summary>
	[ComVisible(false)]
	public class NexoDictionaryOfPartners : NexoDictionaryOfObjects<NexoPartner>
	{
		#region constructor
		public NexoDictionaryOfPartners(string title) : base(title) { }
		#endregion

		#region methods
		/// <summary>
		/// Indicates whether a sale ID is connected to the server or not
		/// </summary>
		/// <param name="o">A <see cref="NexoObject"/> containing information about the SaleID to check</param>
		/// <returns>True if connected, false otherwise</returns>
		public bool IsConnected(NexoPartner o)
		{
			try
			{
				NexoPartner client = this[o.Key];
				NexoSession connection = client.CurrentConnection;
				return null != connection && connection.Connected;
			}
			catch (Exception)
			{
				// the client does not exist or not yet connected
				return false;
			}
		}
		#endregion
	}
}
