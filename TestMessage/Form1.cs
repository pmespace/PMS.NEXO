using NEXO;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TestMessage
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				NexoItem item = new NexoItem(textBox1.Text);
				textBox2.Text = NexoRetailer.XmlSerialize<SaleToPOIResponse>((SaleToPOIResponse)item.Item, false);// Item.ToString();
			}
			catch (Exception ex)
			{

				throw;
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				var x = XElement.Parse(textBox1.Text);
				string s = string.Empty;

#if false
				var response = JObject.Parse(JsonConvert.SerializeXNode(x)
								.Replace("\"@", "\""))
								.ToObject<SaleToPOIResponse>();
				s = JsonConvert.SerializeObject(response);

#else
				var response = JsonConvert.SerializeXNode(x, Formatting.Indented, true).Replace("\"@", "\"");

				//var response = JsonConvert.SerializeXNode(x);
				var resp = JsonConvert.DeserializeObject<SaleToPOIResponse>(response);// new JsonReader( response


				s = response.ToString();
#endif

				textBox3.Text = s;

			}
			catch (Exception ex)
			{

				throw;
			}

		}
	}
}