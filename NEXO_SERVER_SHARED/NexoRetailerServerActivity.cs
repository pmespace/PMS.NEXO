using System;
using System.Reflection;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Text;
using COMMON;
using NEXO;

namespace NEXO.Server
{
	[Guid("F71D22CA-428A-4B19-9412-05F8552EB8F2")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoRetailerServerActivity
	{
		#region owned
		#endregion

		#region inherited
		#endregion
	}

	[Guid("E1E33479-DBC6-4537-80A0-E2F693CADF4A")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoRetailerServerActivity: NexoActivity, INexoRetailerServerActivity
	{
		#region constructor
		public NexoRetailerServerActivity()
		{
			_clients = new NexoDictionaryOfPartners("CLIENTS");
			_endpoints = new NexoDictionaryOfEndPoints("ENDPOINTS");
			_currentlyconnected = new NexoDictionaryOfPartners("CONNECTED CLIENTS");

//#if NET35
			EndPoints = _endpoints;
			Clients = _clients;
			CurrentlyConnected = _currentlyconnected;
//#else
//			EndPoints = new ReadOnlyDictionary<string, NexoEndPoint>(_endpoints);
//			Clients = new ReadOnlyDictionary<string, NexoPartner>(_clients);
//			CurrentlyConnected = new ReadOnlyDictionary<string, NexoPartner>(_currentlyconnected);
//#endif

		}
		#endregion

		#region properties

//#if NET35
		public NexoDictionaryOfEndPoints EndPoints { get => _endpoints; private set => _endpoints = value; }
		public NexoDictionaryOfPartners Clients { get => _clients; private set => _clients = value; }
		public NexoDictionaryOfPartners CurrentlyConnected { get => _currentlyconnected; private set => _currentlyconnected = value; }
//#else
//		/// <summary>
//		/// EndPoints having tried to reach the server
//		/// </summary>
//		public ReadOnlyDictionary<string, NexoEndPoint> EndPoints { get; }
//		/// <summary>
//		/// Clients having been connected
//		/// </summary>
//		public ReadOnlyDictionary<string, NexoPartner> Clients { get; }
//		/// <summary>
//		/// Currently connected clients
//		/// </summary>
//		public ReadOnlyDictionary<string, NexoPartner> CurrentlyConnected { get; }
//#endif

		private NexoDictionaryOfEndPoints _endpoints { get; set; }
		private NexoDictionaryOfPartners _clients { get; set; }
		private NexoDictionaryOfPartners _currentlyconnected { get; set; }

		private object mylock = new object();
		#endregion

		#region methods
		/// <summary>
		/// Insert an EndPoint in the list of ones trying to connect
		/// </summary>
		/// <param name="o"></param>
		/// <returns></returns>
		internal NexoEndPoint AddEndPoint(NexoEndPoint o)
		{
			lock (mylock)
			{
				try
				{
					if (!_endpoints.ContainsKey(o.Key))
					{
						_endpoints.Add(o.Key, o);
					}
					return _endpoints[o.Key];
				}
				catch (Exception ex)
				{
					CLog.AddException(MethodBase.GetCurrentMethod().Name, ex);
				}
				return null;
			}
		}
		/// <summary>
		///  Remove an Endpoint from the list of connected ones
		/// </summary>
		/// <param name="o"></param>
		internal void RemoveEndPoint(NexoEndPoint o)
		{
			lock (mylock)
			{
				try
				{
					_endpoints.Remove(o.Key);
				}
				catch (Exception ex)
				{
					CLog.AddException(MethodBase.GetCurrentMethod().Name, ex);
				}
			}
		}
		/// <summary>
		/// Insert a new client as connected to the server if it is its first connection
		/// Set the client as connected if not the first connection and disconnected
		/// </summary>
		/// <param name="client"></param>
		/// <returns></returns>
		internal NexoPartner AddClient(NexoPartner client)
		{
			lock (mylock)
			{
				try
				{
					if (!_clients.ContainsKey(client.Key))
					{
						_clients.Add(client.Key, client);
					}
					return _clients[client.Key];
				}
				catch (Exception ex)
				{
					CLog.AddException(MethodBase.GetCurrentMethod().Name, ex);
				}
			}
			return null;
		}
		/// <summary>
		/// Add a partner to the list of connected ones
		/// </summary>
		/// <param name="client"></param>
		/// <returns></returns>
		internal bool AddCurrentClient(NexoPartner client)
		{
			lock (mylock)
			{
				try
				{
					if (!_currentlyconnected.ContainsKey(client.Key))
					{
						_currentlyconnected.Add(client.Key, client);
					}
					return true;
				}
				catch (Exception ex)
				{
					CLog.AddException(MethodBase.GetCurrentMethod().Name, ex);
				}
				return false;
			}
		}
		/// <summary>
		/// Remove a partner from the list of connected ones
		/// </summary>
		/// <param name="client"></param>
		/// <returns></returns>
		internal bool RemoveCurrentClient(NexoPartner client)
		{
			lock (mylock)
			{
				try
				{
					if (!_currentlyconnected.ContainsKey(client.Key))
					{
						_currentlyconnected.Remove(client.Key);
					}
					return true;
				}
				catch (Exception ex)
				{
					CLog.AddException(MethodBase.GetCurrentMethod().Name, ex);
				}
				return false;
			}
		}
		#endregion
	}
}