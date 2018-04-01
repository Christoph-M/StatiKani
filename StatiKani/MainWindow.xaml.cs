using System.IO;
using System.Net;
using System.Windows;
using System.Web.Script.Serialization;
using StatiKani.Source.JSONObjects;


namespace StatiKani {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void MakeRequest<DataType>(string endPoint) {
			WebRequest request = WebRequest.Create("https://www.wanikani.com/api/v2/" + endPoint);
			request.Headers.Add(HttpRequestHeader.Authorization, "Bearer 89249d76-0ccb-402d-9e81-dd2ba8444d4d");

			WebResponse response = request.GetResponse();

			Stream dataStream = response.GetResponseStream();
			StreamReader reader = new StreamReader(dataStream);

			string data = reader.ReadToEnd();

			reader.Close();
			response.Close();

			RequestResult_TextBox.Text = data;
			DataType jsonObjs = new JavaScriptSerializer().Deserialize<DataType>(data);
		}

		private void UserRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.MakeRequest<Resource<User>>("user");
		}

		private void AssignmentsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.MakeRequest<Collection<Resource<Assignment>>>("assignments");
		}

		private void SubjectsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.MakeRequest<Collection<Resource<Subject>>>("subjects");
		}

		private void ReviewStatisticsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.MakeRequest<Collection<Resource<ReviewStatistic>>>("review_statistics");
		}

		private void StudyMaterialsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.MakeRequest<Collection<Resource<StudyMaterial>>>("study_materials");
		}

		private void SummaryRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.MakeRequest<Resource<Summary>>("summary");
		}

		private void ReviewsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.MakeRequest<Collection<Resource<Review>>>("reviews");
		}

		private void LevelProgressionsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.MakeRequest<Collection<Resource<LevelProgression>>>("level_progressions");
		}

		private void ResetsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.MakeRequest<Collection<Resource<Reset>>>("resets");
		}
	}
}
