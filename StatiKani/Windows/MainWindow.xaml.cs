using System.Windows;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Windows {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {

		private StatiKani.App statiKaniApp = null;


		public MainWindow() {
			InitializeComponent();
			this.statiKaniApp = (StatiKani.App)Application.Current;
			this.UserInfo_Label.Content = "User: " + this.statiKaniApp.User.UserName + "\tLevel: " + this.statiKaniApp.User.Level;
		}

		private void UserRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<ResourceData<UserData>>("user");
		}

		private void AssignmentsRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<CollectionData<ResourceData<AssignmentData>>>("assignments");
		}

		private void SubjectsRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<CollectionData<ResourceData<SubjectData>>>("subjects");
		}

		private void ReviewStatisticsRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<CollectionData<ResourceData<ReviewStatisticData>>>("review_statistics");
		}

		private void StudyMaterialsRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<CollectionData<ResourceData<StudyMaterialData>>>("study_materials");
		}

		private void SummaryRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<ResourceData<SummaryData>>("summary");
		}

		private void ReviewsRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<CollectionData<ResourceData<ReviewData>>>("reviews");
		}

		private void LevelProgressionsRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<CollectionData<ResourceData<LevelProgressionData>>>("level_progressions");
		}

		private void ResetsRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<CollectionData<ResourceData<ResetData>>>("resets");
		}
	}
}
