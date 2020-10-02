using System;
using System.Collections.Generic;
using System.Text;
using COMMON;
using NEXO;

namespace NEXO
{
	/// <summary>
	/// Generic dictionary of objects
	/// </summary>
	public abstract class NexoListOfObjects<NtX>: List<NtX>
	{
		#region constructor
		public NexoListOfObjects(string objects) { Objects = objects; }
		#endregion

		#region properties
		public string Objects { get; }
		#endregion

		#region methods
		public override string ToString()
		{
			string s = null;
			string t = " - LIST OF " + Objects;
			if (0 == Count)
			{
				return DateTime.Now.ToString(Chars.DATETIME) + t + " IS EMPTY";
			}
			else
			{
				s = DateTime.Now.ToString(Chars.DATETIME) + t;
				foreach (NtX o in this)
					s += Chars.CRLF + Chars.TAB + o.ToString();
			}
			return s;
		}
		#endregion
	}
	public class NexoListOfNexoKeys: NexoListOfObjects<NexoKey>
	{
		public NexoListOfNexoKeys(string objects) : base(objects) { }
	}

	/// <summary>
	/// Generic dictionary of objects
	/// </summary>
	public abstract class NexoDictionaryOfObjects<NtX>: Dictionary<string, NtX>
	{
		#region constructor
		public NexoDictionaryOfObjects(string objects) { Objects = objects; }
		#endregion

		#region properties
		public string Objects { get; }
		#endregion

		#region methods
		public override string ToString()
		{
			string s = null;
			string t = " - LIST OF " + Objects;
			if (0 == Count)
			{
				return DateTime.Now.ToString(Chars.DATETIME) + t + " IS EMPTY";
			}
			else
			{
				s = DateTime.Now.ToString(Chars.DATETIME) + t;
				foreach (KeyValuePair<string, NtX> o in this)
					s += Chars.CRLF + Chars.TAB + o.Value.ToString();
			}
			return s;
		}
		#endregion
	}
	public class NexoDictionaryOfNexoKeys: NexoDictionaryOfObjects<NexoKey>
	{
		public NexoDictionaryOfNexoKeys(string objects) : base(objects) { }
	}
}
