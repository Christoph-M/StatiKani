using System.Windows;


namespace StatiKani {
	/// <summary>
	/// Interaction logic for APIKeyPromptWindow.xaml
	/// </summary>
	public partial class APIKeyPromptWindow : Window {

		private StatiKani.App statiKaniApp = null;


		public APIKeyPromptWindow() {
			InitializeComponent();
			this.statiKaniApp = (StatiKani.App)Application.Current;
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			if (APIKeyInput_TextBox.Text == string.Empty) {
				this.Feedback_Label.Content = "Input field is empty.";
				return;
			}

			if (!this.statiKaniApp.TestAPIKey(APIKeyInput_TextBox.Text)) {
				this.Feedback_Label.Content = "Invalid API key.";
				return;
			}

			this.statiKaniApp.OpenMainWindow();
		}

		private void OpenSettings_Button_Click(object sender, RoutedEventArgs e) {
			System.Diagnostics.Process.Start("https://www.wanikani.com/settings/account");
		}
	}
}
