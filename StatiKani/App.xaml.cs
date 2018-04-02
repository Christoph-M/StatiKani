using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows;


namespace StatiKani {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application {

		private string apiKey = null;


		public void OpenMainWindow() {
			MainWindow mainWindow = new MainWindow();
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
				MessageBox.Show(exception.Message);
			}

			return null;
		}
	}
}
