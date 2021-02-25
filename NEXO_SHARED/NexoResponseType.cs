using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using COMMON;

namespace NEXO
{
	[Guid("5987CC8F-70A4-4FB9-BCEA-71A706CA27C9")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoResponseType
	{
		#region owned
		[DispId(1)]
		ResultEnumeration Result { get; set; }
		[DispId(2)]
		ErrorConditionEnumeration ErrorCondition { get; set; }
		[DispId(3)]
		string AdditionalResponse { get; set; }

		[DispId(100)]
		ResponseType Response();
		#endregion
	}
	[Guid("9C9B6CF4-A8B9-4AC1-99EC-6B940F5B09E1")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class NexoResponseType : INexoResponseType
	{
		#region constructor
		public NexoResponseType()
		{
			Result = ResultEnumeration.Success;
			ErrorCondition = (ErrorConditionEnumeration)NexoValues.None;
			AdditionalResponse = null;
		}
		public NexoResponseType(ResponseType response)
		{
			this.response = response;
		}
		#endregion

		#region properties
		private ResponseType response = new ResponseType();
		public ResultEnumeration Result
		{
			get => (ResultEnumeration)CMisc.StringToEnumValue(typeof(ResultEnumeration), response.Result);
			set
			{
				if (CMisc.IsEnumValue(typeof(ResultEnumeration), value))
					response.Result = CMisc.GetEnumName(typeof(ResultEnumeration), value);
				else
					response.Result = ResultEnumeration.Failure.ToString();
			}
		}
		public ErrorConditionEnumeration ErrorCondition
		{
			get => (ErrorConditionEnumeration)CMisc.StringToEnumValue(typeof(ErrorConditionEnumeration), response.ErrorCondition);
			set
			{
				if (CMisc.IsEnumValue(typeof(ErrorConditionEnumeration), value))
					response.ErrorCondition = CMisc.GetEnumName(typeof(ErrorConditionEnumeration), value);
				else
					response.ErrorCondition = null;
			}
		}
		public string AdditionalResponse
		{
			get => response.AdditionalResponse;
			set => response.AdditionalResponse = value;
		}
		#endregion

		#region constructor
		public ResponseType Response() { return response; }
		public static NexoResponseType Response(ResponseType response) { return new NexoResponseType(response); }
		#endregion
	}
}
