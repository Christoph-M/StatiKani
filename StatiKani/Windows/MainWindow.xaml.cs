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
			ItemUser userItem = this.statiKaniApp.MakeResourceRequest<ItemUser>(EJsonDataObjectType.User);
		}

		private void AssignmentsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.statiKaniApp.MakeCollectionRequest(EJsonDataObjectType.Assignments);
		}

		private void SubjectsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.statiKaniApp.MakeCollectionRequest(EJsonDataObjectType.Subjects);
		}

		private void ReviewStatisticsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.statiKaniApp.MakeCollectionRequest(EJsonDataObjectType.ReviewStatistics);
		}

		private void StudyMaterialsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.statiKaniApp.MakeCollectionRequest(EJsonDataObjectType.StudyMaterials);
		}

		private void SummaryRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.statiKaniApp.MakeResourceRequest<ItemSummary>(EJsonDataObjectType.Summary);
		}

		private void ReviewsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.statiKaniApp.MakeCollectionRequest(EJsonDataObjectType.Reviews);
		}

		private void LevelProgressionsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.statiKaniApp.MakeCollectionRequest(EJsonDataObjectType.LevelProgressions);
		}

		private void ResetsRequest_Button_Click(object sender, RoutedEventArgs e) {
			this.statiKaniApp.MakeCollectionRequest(EJsonDataObjectType.Resets);
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			ItemCollection data = this.statiKaniApp.MakeCollectionRequest(EJsonDataObjectType.Reviews);
			ItemReview[] itemReviews = data.ItemData.Cast<ItemReview>().ToArray();
		}
	}
}
