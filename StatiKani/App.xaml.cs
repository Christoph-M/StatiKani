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
				WebRequest request = WebRequest.Create("https://api.wanikani.com/v2/user");
				request.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + apiKey);

				WebResponse response = request.GetResponse();

				Stream dataStream = response.GetResponseStream();
				StreamReader reader = new StreamReader(dataStream);

				string data = reader.ReadToEnd();

				reader.Close();
				response.Close();

				this.user = new ItemUser(new JavaScriptSerializer().Deserialize<UserData>(data));
			} catch (System.Exception exception) {
				return false;
			}

			this.apiKey = apiKey;

			return true;
		}

		public ItemCollection MakeFullUrlCollectionRequest(string url, EJsonDataObjectType jsonDataObjectType) {
			string data = this.MakeRequest(url);
			return data == string.Empty ? default(ItemCollection) : ItemCollection.CollectionFactory(jsonDataObjectType, data);
		}

		public ItemCollection MakeCollectionRequest(string endPoint, EJsonDataObjectType jsonDataObjectType) {
			string data = this.MakeRequest("https://www.wanikani.com/api/v2/" + endPoint);
			return data == string.Empty ? default(ItemCollection) : ItemCollection.CollectionFactory(jsonDataObjectType, data);
		}

		public ItemBase MakeFullUrlResourceRequest(string url, EJsonDataObjectType jsonDataObjectType) {
			string data = this.MakeRequest(url);
			return data == string.Empty ? default(ItemBase) : ItemBase.ItemFactory(jsonDataObjectType, data);
		}

		public ItemBase MakeResourceRequest(string endPoint, EJsonDataObjectType jsonDataObjectType) {
			string data = this.MakeRequest("https://www.wanikani.com/api/v2/" + endPoint);
			return data == string.Empty ? default(ItemBase) : ItemBase.ItemFactory(jsonDataObjectType, data);
		}

		private string MakeRequest(string url) {
			try {
				WebRequest request = WebRequest.Create(url);
				request.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + this.apiKey);

				WebResponse response = request.GetResponse();

				Stream dataStream = response.GetResponseStream();
				StreamReader reader = new StreamReader(dataStream);

				string data = reader.ReadToEnd();

				reader.Close();
				response.Close();

				return data;
			}
			catch (System.Exception exception) {
				MessageBox.Show(exception.Message);
				return string.Empty;
			}
		}
	}
}
