namespace NEXO
{
	public abstract class NexoKey
	{
		#region properties
		public string Key
		{
			get => _key;
			protected set { _key = value; }
		}
		private string _key = null;
		protected string SEP
		{
			get => _sep;
			set => _sep = value;
		}
		private string _sep = " - ";
		public string Description
		{
			get => string.IsNullOrEmpty(_description) ? Key : _description + ": " + Key;
			protected set => _description = value;
		}
		private string _description = null;
		#endregion

		#region methods
		protected string ToString(bool addkey, string s)
		{
			return (addkey ? Key + SEP : null) + s;
		}
		public override string ToString()
		{
			return Description + SEP + ToString(false);
		}
		public abstract string ToString(bool addkey);
		#endregion
	}
}
