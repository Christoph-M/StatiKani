using System.Windows;
using StatiKani.Source.JSONObjects;


namespace StatiKani {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {

		private StatiKani.App statiKaniApp = null;


		public MainWindow() {
			InitializeComponent();
			this.statiKaniApp = (StatiKani.App)Application.Current;
		}

		private void UserRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<Resource<User>>("user");
		}

		private void AssignmentsRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<Collection<Resource<Assignment>>>("assignments");
		}

		private void SubjectsRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<Collection<Resource<Subject>>>("subjects");
		}

		private void ReviewStatisticsRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<Collection<Resource<ReviewStatistic>>>("review_statistics");
		}

		private void StudyMaterialsRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<Collection<Resource<StudyMaterial>>>("study_materials");
		}

		private void SummaryRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<Resource<Summary>>("summary");
		}

		private void ReviewsRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<Collection<Resource<Review>>>("reviews");
		}

		private void LevelProgressionsRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<Collection<Resource<LevelProgression>>>("level_progressions");
		}

		private void ResetsRequest_Button_Click(object sender, RoutedEventArgs e) {
			RequestResult_TextBox.Text = this.statiKaniApp.MakeRequest<Collection<Resource<Reset>>>("resets");
		}
	}
}
