using System;
using System.Linq;
using System.Windows;
using StatiKani.Source.Items;
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
			ItemUser userItem = (ItemUser)this.statiKaniApp.MakeResourceRequest("user", EJsonDataObjectType.User);
		}

		private void AssignmentsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.statiKaniApp.MakeCollectionRequest("assignments", EJsonDataObjectType.Assignments);
		}

		private void SubjectsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.statiKaniApp.MakeCollectionRequest("subjects", EJsonDataObjectType.Subjects);
		}

		private void ReviewStatisticsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.statiKaniApp.MakeCollectionRequest("review_statistics", EJsonDataObjectType.ReviewStatistics);
		}

		private void StudyMaterialsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.statiKaniApp.MakeCollectionRequest("study_materials", EJsonDataObjectType.StudyMaterials);
		}

		private void SummaryRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.statiKaniApp.MakeResourceRequest("summary", EJsonDataObjectType.Summary);
		}

		private void ReviewsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.statiKaniApp.MakeCollectionRequest("reviews", EJsonDataObjectType.Reviews);
		}

		private void LevelProgressionsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.statiKaniApp.MakeCollectionRequest("level_progressions", EJsonDataObjectType.LevelProgression);
		}

		private void ResetsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.statiKaniApp.MakeCollectionRequest("resets", EJsonDataObjectType.Resets);
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			ItemCollection data = this.statiKaniApp.MakeCollectionRequest("reviews", EJsonDataObjectType.Reviews);
			ItemReview[] itemReviews = data.ItemData.Cast<ItemReview>().ToArray();
		}
	}
}
