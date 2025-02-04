﻿using System.Runtime.InteropServices;
using System.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Text;
using COMMON;

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
	//	bool OnStartDelegate(CThread thread, object o);
	//	bool OnConnectDelegate(TcpClient tcp, CThread thread, object o);
	//	void OnReceivedDelegate(string xml, NexoObjectToProcess msg, TcpClient tcp, CThread thread, object o);
	//	void OnSendDelegate(string xml, NexoItem item, TcpClient tcp, CThread thread, object o);
	//	void OnStopDelegate(CThread thread, object o);
	//	void OnSentRequestStatusChangedDelegate(string xml, NexoObjectToProcess msg, TcpClient tcp, CThread thread, object o);
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
		/// <param name="threadData">Thread object</param>
		/// <param name="parameters">Private parameters passed by the caller</param>
		/// <returns>FALSE if the server must stop immediately before receiving any request, TRUE if the server must carry on</returns>
		[ComVisible(false)]
		public delegate bool OnStartDelegate(CThreadData threadData, object parameters);
		/// <summary>
		/// Function called when a client connects to the server
		/// </summary>
		/// <param name="tcp">Information about the connecting client</param>
		/// <param name="thread">Thread object</param>
		/// <param name="parameters">Private parameters passed by the caller</param>
		/// <param name="privateData">Private data which can be allocated per client at connection time</param>
		/// <returns>FALSE if the server must stop immediately before receiving any request, TRUE if the server must carry on</returns>
		[ComVisible(false)]
		public delegate bool OnConnectDelegate(TcpClient tcp, CThread thread, object parameters, ref object privateData);
		/// <summary>
		/// Function called when a client disconnects from the server
		/// </summary>
		/// <param name="remoteClient">The remote address being disconnected</param>
		/// <param name="thread">Thread object</param>
		/// <param name="parameters">Private parameters to pass to the thread</param>
		/// <param name="statistics">Statistics  of exchanges with the client</param>
		[ComVisible(false)]
		public delegate void OnDisconnectDelegate(TcpClient remoteClient, CThread thread, object parameters, CStreamServerStatistics statistics);
		/// <summary>
		/// Called whenever a <see cref="SaleToPOIRequest"/> or <see cref="SaleToPOIResponse"/> has been received and needs to be processed by the application.
		/// The function is expected to either (1) produce a reply (2) produce a new request (device) (3) do nothing.
		/// </summary>
		/// <param name="xml">The xml message received</param>
		/// <param name="msg">The message to process</param>
		/// <param name="tcp">Tcp details of the calling client</param>
		/// <param name="thread">Thread object</param>
		/// <param name="parameters">Private parameters passed by the caller</param>
		[ComVisible(false)]
		public delegate void OnReceivedDelegate(string xml, NexoObjectToProcess msg, TcpClient tcp, CThread thread, object parameters);
		/// <summary>
		/// Called to inform the application of the message which will be sent back after having received a message.
		/// If no message to send back this function is not called.
		/// </summary>
		/// <param name="xml">The xml message that will be sent</param>
		/// <param name="item">The message as it will be sent, no modification is possible</param>
		/// <param name="tcp">Tcp details of the calling client</param>
		/// <param name="thread">Thread object</param>
		/// <param name="threadData">Thread data (in case thread is null)</param>
		/// <param name="parameters">Private parameters passed by the caller</param>
		[ComVisible(false)]
		public delegate void OnSendDelegate(string xml, NexoItem item, TcpClient tcp, CThread thread, CThreadData threadData, object parameters);
		/// <summary>
		/// Function called when the server is stopping (after having received a stop order).
		/// </summary>
		/// <param name="threadData">Thread object</param>
		/// <param name="parameters">Private parameters passed by the caller</param>
		[ComVisible(false)]
		public delegate void OnStopDelegate(CThreadData threadData, object parameters);
		/// <summary>
		/// Called to inform the application a request message hasn't received a response and the message has been dismissed.
		/// </summary>
		/// <param name="xml">The xml message that has been sent and is in error</param>
		/// <param name="msg">The message in a PC readable format, no modification is possible</param>
		/// <param name="status">Indicates the status of the message explaining why it hasn't been processed</param>
		/// <param name="tcp">Tcp details of the called server</param>
		/// <param name="thread">Thread object</param>
		/// <param name="parameters">Private parameters passed by the caller</param>
		[ComVisible(false)]
		public delegate void OnSentRequestStatusChangedDelegate(string xml, NexoObjectToProcess msg, NexoMessageStatus status, TcpClient tcp, CThread thread, object parameters);
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
