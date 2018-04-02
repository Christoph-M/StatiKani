using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows;
using StatiKani.Source.Items;
using StatiKani.Source.JSONObjects;


namespace StatiKani {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application {

		public string ApiKey => this.apiKey;
		public ItemUser User => this.user;

		private string apiKey = null;
		private ItemUser user = null;


		public void OpenMainWindow() {
			Windows.MainWindow mainWindow = new Windows.MainWindow();
			mainWindow.InitializeComponent();

			if (Windows.Count > 0) Windows[0].Close();

			mainWindow.Show();
		}

		public bool TestAPIKey(string apiKey) {
			try {
				WebRequest request = WebRequest.Create("https://www.wanikani.com/api/v2/user");
				request.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + apiKey);

				WebResponse response = request.GetResponse();

				Stream dataStream = response.GetResponseStream();
				StreamReader reader = new StreamReader(dataStream);

				string data = reader.ReadToEnd();

				reader.Close();
				response.Close();

				this.user = new ItemUser(new JavaScriptSerializer().Deserialize<ResourceData<UserData>>(data));
			} catch (System.Exception exception) {
				return false;
			}

			this.apiKey = apiKey;

			return true;
		}

		public string MakeRequest<DataType>(string endPoint) {
			try {
				WebRequest request = WebRequest.Create("https://www.wanikani.com/api/v2/" + endPoint);
				request.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + this.apiKey);

				WebResponse response = request.GetResponse();

				Stream dataStream = response.GetResponseStream();
				StreamReader reader = new StreamReader(dataStream);

				string data = reader.ReadToEnd();

				reader.Close();
				response.Close();

				DataType jsonObjs = new JavaScriptSerializer().Deserialize<DataType>(data);
				return data;
			} catch (System.Exception exception) {
				return exception.Message;
			}
		}
	}
}
