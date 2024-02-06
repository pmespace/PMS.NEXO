using System.Collections.Generic;
using System.Text.RegularExpressions;
using COMMON;

namespace Listener.Shared
{
	/// <summary>
	/// Details a data to send or receive when triggering a service. Its format is:
	/// Dataname[([numeric value])] where
	/// - The whole entry is stored in <see cref="Element"/>
	/// - Dataname is <see cref="CListenerData.Name"/>
	/// - The presence of "()" indicates it is an array (<see cref="CListenerData.isArray"/> = true)
	/// - The presence of "numeric value" sets <see cref="CListenerData.Index"/>
	/// </summary>
	class CListenerData
	{
		public string Element = string.Empty;
		public string Name = string.Empty;
		public bool isArray { get => -1 != Index; }
		public int Index = -1;
		public bool IsValid => !Name.IsNullOrEmpty();
		public override string ToString() => Element;
	}
	/// <summary>
	/// Describes a serie of <see cref="CListenerData"/> to form an access to a particular data
	/// </summary>
	class CListenerPath : List<CListenerData>
	{
		public CListenerPath() { }
		public CListenerPath(CListenerPath l) : base(l) { }
		public bool IsEmpty => 0 == this.Count || ToString().IsNullOrEmpty();
		public override string ToString()
		{
			string s = string.Empty;
			for (int i = 0; i < this.Count; i++)
				s += (0 == i ? string.Empty : ".") + this[i].Element;
			return s;
		}
		/// <summary>
		/// Converts a string to its <see cref="CListenerPath"/> counter part (if possible)
		/// The string is analysed using regex
		/// Inside a set of elements will be searched using the following pattern
		/// (?<element>(?<name>[A-Z-a-z0-9]+)(?<array>(\({1} (?< index > [0 - 9] +)\){ 1})?))(?< separator >\.?)
		/// </summary>
		/// <param name="value">The string to analyse; its format is data1[.data2[.data3]]
		/// <param name="set"></param>
		/// <returns></returns>
		public static CListenerPath PathToData(string value, bool set)
		{
			value = value.Trim();
			CListenerPath paths = new CListenerPath();
			// names of the groups to locate that will indicate which part is included
			string selement = "element", sname = "name", sarray = "array", sindex = "index", sseparator = "separator";
			string pattern = $"(?<{selement}>(?<{sname}>[A-Z-a-z0-9]+)(?<{sarray}>(\\({1}(?<{sindex}>[0-9]{(set ? "+" : "*")})\\){1})?))(?<{sseparator}>\\.?)";
			MatchCollection mc = Regex.Matches(value, pattern);
			foreach (Match match in mc)
			{
				CListenerData o = match.Groups[sname].Value.IsNullOrEmpty() ? null : new CListenerData() { Name = match.Groups[sname].Value };
				if (null != o && o.IsValid)
				{
					o.Element = match.Groups[selement].Value;
					if (!match.Groups[sarray].Value.IsNullOrEmpty())
						_ = int.TryParse(match.Groups[sindex].Value, out o.Index);
					paths.Add(o);
				}
			}
			if (!value.Compare(paths.ToString()))
				paths.Clear();
			return paths;
		}
	}

	public struct CListenerDataElement
	{
		public List<object> Value;
		public bool Status;
		public override string ToString()
		{
			string s = string.Empty;
			if (null == Value) return s;
			foreach (object k in Value)
				s += $"{k}; ";
			return s + "({Status})";
		}
	}
	public class CListenerDataElements : Dictionary<string, CListenerDataElement>
	{
		public CListenerDataElements() { }
		public CListenerDataElements(CListenerDataElements data) : base(data) { }
		public CListenerDataElements(Dictionary<string, CListenerDataElement> data) : base(data) { }
		public override string ToString()
		{
			string s = string.Empty;
			s += (0 == Count ? $"<none>" : string.Empty) + Chars.CRLF;
			foreach (KeyValuePair<string, CListenerDataElement> k in this)
				s += Chars.TAB + $"- {k.Key}{k.Value.Value}" + Chars.CRLF;
			return s;
		}

	}
}