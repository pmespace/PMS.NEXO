using System.Runtime.InteropServices;
using System.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Text;
using COMMON;
using NEXO;

namespace NEXO
{
	[ComVisible(true)]
	public enum NexoMessageStatus
	{
		normal,
		timeout,
		cancelled,
	}
	//[Guid("AFCAD1D4-52BA-4323-91FB-28BA33EB342E")]
	//[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	//[ComVisible(true)]
	//public interface INexoDelegates
	//{
	//	#region INexoDelegates
	//	bool OnStartDelegate(CThreadData threadData, object o);
	//	bool OnConnectDelegate(TcpClient tcp, CThreadData threadData, object o);
	//	void OnReceivedDelegate(string xml, NexoObjectToProcess msg, TcpClient tcp, CThreadData threadData, object o);
	//	void OnSendDelegate(string xml, NexoItem item, TcpClient tcp, CThreadData threadData, object o);
	//	void OnStopDelegate(CThreadData threadData, object o);
	//	void OnSentRequestStatusChangedDelegate(string xml, NexoObjectToProcess msg, TcpClient tcp, CThreadData threadData, object o);
	//	#endregion
	//}
	/// <summary>
	/// Functions called inside the application context to inform of an event
	/// </summary>
	//[Guid("D1443DFA-D10F-44ED-8DFD-54114EAA7F22")]
	//[ClassInterface(ClassInterfaceType.None)]
	//[ComVisible(true)]
	public class NexoDelegates//: INexoDelegates
	{
		/// <summary>
		/// Function called when the server thread starts, before having received any request to process.
		/// </summary>
		/// <param name="threadData">Thread data</param>
		/// <param name="o">Private parameters passed by the caller</param>
		/// <returns>FALSE if the server must stop immediately before receiving any request, TRUE if the server must carry on</returns>
		[ComVisible(false)]
		public delegate bool OnStartDelegate(CThreadData threadData, object o);
		/// <summary>
		/// Function called when a client connects to the server
		/// </summary>
		/// <param name="tcp">Information about the connecting client</param>
		/// <param name="threadData">Thread data</param>
		/// <param name="o">Private parameters passed by the caller</param>
		/// <returns>FALSE if the server must stop immediately before receiving any request, TRUE if the server must carry on</returns>
		[ComVisible(false)]
		public delegate bool OnConnectDelegate(TcpClient tcp, CThreadData threadData, object o);
		/// <summary>
		/// Function called when a client disconnects from the server
		/// </summary>
		/// <param name="remoteClient">The remote address being disconnected</param>
		/// <param name="threadData">Thread ID as given by the creator of the thread</param>
		/// <param name="o">Private parameters to pass to the thread</param>
		[ComVisible(false)]
		public delegate void OnDisconnectDelegate(string remoteClient, CThreadData threadData, object o);
		/// <summary>
		/// Called whenever a <see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIResponse"/> has been received and needs to be processed by the application.
		/// The function is expected to either (1) produce a reply (2) produce a new request (device) (3) do nothing.
		/// </summary>
		/// <param name="xml">The xml message received</param>
		/// <param name="msg">The message to process</param>
		/// <param name="tcp">Tcp details of the calling client</param>
		/// <param name="threadData">Thread data</param>
		/// <param name="o">Private parameters passed by the caller</param>
		[ComVisible(false)]
		public delegate void OnReceivedDelegate(string xml, NexoObjectToProcess msg, TcpClient tcp, CThreadData threadData, object o);
		/// <summary>
		/// Called to inform the application of the message which will be sent back after having received a message.
		/// If no message to send back this function is not called.
		/// </summary>
		/// <param name="xml">The xml message that will be sent</param>
		/// <param name="item">The message as it will be sent, no modification is possible</param>
		/// <param name="tcp">Tcp details of the calling client</param>
		/// <param name="threadData">Thread data</param>
		/// <param name="o">Private parameters passed by the caller</param>
		[ComVisible(false)]
		public delegate void OnSendDelegate(string xml, NexoItem item, TcpClient tcp, CThreadData threadData, object o);
		/// <summary>
		/// Function called when the server is stopping (after having received a stop order).
		/// </summary>
		/// <param name="threadData">Thread data</param>
		/// <param name="o">Private parameters passed by the caller</param>
		[ComVisible(false)]
		public delegate void OnStopDelegate(CThreadData threadData, object o);
		/// <summary>
		/// Called to inform the application a request message hasn't received a response and the message has been dismissed.
		/// </summary>
		/// <param name="xml">The xml message that has been sent and is in error</param>
		/// <param name="msg">The message in a PC readable format, no modification is possible</param>
		/// <param name="status">Indicates the status of the message explaining why it hasn't been processed</param>
		/// <param name="tcp">Tcp details of the called server</param>
		/// <param name="threadData">Thread data</param>
		/// <param name="o">Private parameters passed by the caller</param>
		[ComVisible(false)]
		public delegate void OnSentRequestStatusChangedDelegate(string xml, NexoObjectToProcess msg, NexoMessageStatus status, TcpClient tcp, CThreadData threadData, object o);
		/// <summary>
		/// Called to set the pre-connection request string to send before sending any Nexo message
		/// </summary>
		/// <param name="settings">The <see cref="CStreamClientSettings"/> object used to connect</param>
		/// <returns>An to send right after the connection and before receiving any message, null if no pre-connection object to use</returns>
		[ComVisible(false)]
		public delegate object OnConnectionRequestDelegate(CStreamClientSettings settings);
		/// <summary>
		/// Called to analyse the pre-connection reply string
		/// </summary>
		/// <param name="reply">The object received and to analyse to determine whether pre-connection is accepted or not</param>
		/// <returns>True is pre-connection<see langword="abstract"/>,  then access, has been granted , false otherwise</returns>
		[ComVisible(false)]
		public delegate bool OnConnectionReplyDelegate(object reply);
	}
}
