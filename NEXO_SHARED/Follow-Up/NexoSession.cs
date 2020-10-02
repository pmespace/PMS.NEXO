using System;
using System.Collections.Generic;
using System.Text;
using COMMON;

namespace NEXO
{
	/// <summary>
	/// A connection describes the Login/Logout of a Sale or POI
	/// </summary>
	public class NexoSession: NexoKey
	{
		#region constructor
		public NexoSession(NexoPartner o)
		{
			Accepted = false;
			ConnectedTimestamp = default;
			DisconnectedTimestamp = default;
			Key = GetKey(o);
			Description = GetDescription();
		}
		#endregion

		#region properties
		/// <summary>
		/// Indicates whether connection was granted or not
		/// If not, <see cref="ConnectedTimestamp"/> and <see cref="DisconnectedTimestamp"/> are not set
		/// </summary>
		public bool Accepted { get; private set; }
		/// <summary>
		/// Connection timestamp
		/// </summary>
		public DateTime ConnectedTimestamp { get; private set; }
		/// <summary>
		/// Disconnection timestamp
		/// </summary>
		public DateTime DisconnectedTimestamp { get; private set; }
		/// <summary>
		/// Connected/Disconnected flag
		/// </summary>
		public bool Connected { get => Accepted && default(DateTime) == DisconnectedTimestamp; }
		/// <summary>
		/// Last connection/disconnection timestamp
		/// </summary>
		public DateTime LastEvent { get => Accepted ? Connected ? ConnectedTimestamp : DisconnectedTimestamp : default(DateTime); }
		#endregion

		#region methods
		internal static string GetKey(NexoPartner o)
		{
			return o.Key;
		}
		public static string GetDescription()
		{
			return "Session";
		}
		/// <summary>
		/// Indicate the session was granted connection
		/// </summary>
		internal void SetConnected()
		{
			// if not already connected
			if (!Accepted)
			{
				Accepted = true;
				DisconnectedTimestamp = default;
				ConnectedTimestamp = DateTime.Now;
			}
		}
		/// <summary>
		/// Indicate the session is no longer on
		/// </summary>
		public void SetDisconnected()
		{
			if (Accepted && Connected)
			{
				// set disconnected flag
				DisconnectedTimestamp = DateTime.Now;
			}
		}
		public override string ToString(bool addkey)
		{
			return ToString(addkey, Accepted ? ("Connected at: " + ConnectedTimestamp.ToString(Chars.DATETIME) + SEP + (Connected ? "Still connected" : "Disconnected at: " + DisconnectedTimestamp.ToString(Chars.DATETIME))) : "Connection declined");
		}
		#endregion
	}

	public class NexoListOfSessions: NexoListOfObjects<NexoSession>
	{
		public NexoListOfSessions(string title) : base(title) { }
	}

	public class NexoDictionaryOfSessions: NexoDictionaryOfObjects<NexoSession>
	{
		public NexoDictionaryOfSessions(string title) : base(title) { }
	}
}
