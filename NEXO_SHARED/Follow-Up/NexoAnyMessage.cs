using System;
using System.Runtime.InteropServices;
using COMMON;

namespace NEXO
{
	[Guid("1ADB3E04-8743-492B-94C5-4F973C27B951")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	public interface INexoAnyMessage
	{
		#region INexoAnyMessage
		[DispId(1)]
		bool Processed { get; set; }
		[DispId(2)]
		string XML { get; }
		[DispId(3)]
		DateTime Timestamp { get; }

		[DispId(100)]
		string ToString(bool addkey);
		#endregion
	}

	/// <summary>
	/// A nexo message received or sent by any entity
	/// </summary>
	[ComVisible(false)]
	public class NexoAnyMessage: NexoKey, INexoAnyMessage
	{
		#region constructor
		public NexoAnyMessage(string xml)
		{
			Timestamp = DateTime.Now;
			Processed = true;
			XML = xml;
			Key = GetKey(this);
			Description = GetDescription();
		}
		#endregion

		#region properties
		public bool Processed { get; set; }
		public string XML { get; }
		public DateTime Timestamp { get; }
		#endregion

		#region methods
		public static string GetKey(NexoAnyMessage o)
		{
			return o.Timestamp.ToString(Chars.DATETIMEEX);
		}
		public static string GetDescription()
		{
			return "Timestamp";
		}
		public override string ToString(bool addkey)
		{
			return ToString(addkey, "XML: " + XML + " (PROCESSED: " + Processed.ToString() + ")");
		}
		#endregion
	}

	[ComVisible(true)]
	public class NexoListOfAnyMessages: NexoListOfObjects<NexoAnyMessage>
	{
		public NexoListOfAnyMessages(string objects) : base(objects) { }
	}

	[ComVisible(true)]
	public class NexoDictionaryOfAnyMessages: NexoDictionaryOfObjects<NexoAnyMessage>
	{
		public NexoDictionaryOfAnyMessages(string objects) : base(objects) { }
	}

}
