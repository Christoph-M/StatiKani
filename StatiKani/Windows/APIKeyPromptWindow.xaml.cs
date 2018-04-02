using System;
using System.Windows;
using System.Windows.Controls;


namespace StatiKani.Windows {
	/// <summary>
	/// Interaction logic for APIKeyPromptWindow.xaml
	/// </summary>
	public partial class APIKeyPromptWindow : Window {

		private StatiKani.App statiKaniApp = null;
		private TextBox[] apiKeyInputTextBoxes;


		public APIKeyPromptWindow() {
			InitializeComponent();
			WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
			this.statiKaniApp = (StatiKani.App)Application.Current;
			DataObject.AddPastingHandler(this.APIKeyPart1Input_TextBox, this.APIKeyPart1Input_TextBox_OnPase);
			DataObject.AddPastingHandler(this.APIKeyPart2Input_TextBox, this.APIKeyPart2Input_TextBox_OnPase);
			DataObject.AddPastingHandler(this.APIKeyPart3Input_TextBox, this.APIKeyPart3Input_TextBox_OnPase);
			DataObject.AddPastingHandler(this.APIKeyPart4Input_TextBox, this.APIKeyPart4Input_TextBox_OnPase);
			DataObject.AddPastingHandler(this.APIKeyPart5Input_TextBox, this.APIKeyPart5Input_TextBox_OnPase);
			this.apiKeyInputTextBoxes = new TextBox[5] {
														   this.APIKeyPart1Input_TextBox,
														   this.APIKeyPart2Input_TextBox,
														   this.APIKeyPart3Input_TextBox,
														   this.APIKeyPart4Input_TextBox,
														   this.APIKeyPart5Input_TextBox
													   };
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			string apiString = string.Join("-",
						this.APIKeyPart1Input_TextBox.Text,
						this.APIKeyPart2Input_TextBox.Text,
						this.APIKeyPart3Input_TextBox.Text,
						this.APIKeyPart4Input_TextBox.Text,
						this.APIKeyPart5Input_TextBox.Text
			);

			if (!this.statiKaniApp.TestAPIKey(apiString)) {
				this.Feedback_Label.Content = "Invalid API key.";

				return;
			}

			this.statiKaniApp.OpenMainWindow();
		}

		private void OpenSettings_Button_Click(object sender, RoutedEventArgs e) {
			System.Diagnostics.Process.Start("https://www.wanikani.com/settings/account");
		}

		private void Quit_Button_Click(object sender, RoutedEventArgs e) { this.statiKaniApp.Shutdown(); }

		private bool RetrieveApiString(IDataObject sourceDataObject, int maxCharacters, out string apiString) {
			apiString = null;
			bool isString = sourceDataObject.GetDataPresent(DataFormats.StringFormat, true);
			if (!isString) return false;
			apiString = (string)sourceDataObject.GetData(DataFormats.StringFormat);

			if (apiString == string.Empty) {
				this.Feedback_Label.Content = "Input field is empty.";
				return false;
			}

			if (apiString.Length == maxCharacters) return true;

			if (apiString.Length != 36 || !apiString.Contains("-")) {
				this.Feedback_Label.Content =
					apiString.Length == 32 ? "That's your APIV1 key. I need your APIV2 key." : "Invalid API key.";

				return false;
			}

			string[] apiKeyParts = apiString.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

			if (apiKeyParts.Length < 1 || apiKeyParts.Length > 5) return false;
			for (var i = 0; i < apiKeyParts.Length; i++) {
				string apiKeyPart = apiKeyParts[i];
				if (apiKeyPart.Length != this.apiKeyInputTextBoxes[i].MaxLength) continue;
				this.apiKeyInputTextBoxes[i].Text = apiKeyPart;
			}

			return false;
		}

		private void APIKeyPart1Input_TextBox_OnPase(object sender, DataObjectPastingEventArgs e) {
			e.CancelCommand();
			if (!this.RetrieveApiString(e.SourceDataObject, this.APIKeyPart1Input_TextBox.MaxLength, out string apiString)) return;
			this.APIKeyPart1Input_TextBox.Text = apiString;
		}

		private void APIKeyPart2Input_TextBox_OnPase(object sender, DataObjectPastingEventArgs e) {
			e.CancelCommand();
			if (!this.RetrieveApiString(e.SourceDataObject, this.APIKeyPart2Input_TextBox.MaxLength, out string apiString)) return;
			this.APIKeyPart2Input_TextBox.Text = apiString;
		}

		private void APIKeyPart3Input_TextBox_OnPase(object sender, DataObjectPastingEventArgs e) {
			e.CancelCommand();
			if (!this.RetrieveApiString(e.SourceDataObject, this.APIKeyPart3Input_TextBox.MaxLength, out string apiString)) return;
			this.APIKeyPart3Input_TextBox.Text = apiString;
		}

		private void APIKeyPart4Input_TextBox_OnPase(object sender, DataObjectPastingEventArgs e) {
			e.CancelCommand();
			if (!this.RetrieveApiString(e.SourceDataObject, this.APIKeyPart4Input_TextBox.MaxLength, out string apiString)) return;
			this.APIKeyPart4Input_TextBox.Text = apiString;
		}

		private void APIKeyPart5Input_TextBox_OnPase(object sender, DataObjectPastingEventArgs e) {
			e.CancelCommand();
			if (!this.RetrieveApiString(e.SourceDataObject, this.APIKeyPart5Input_TextBox.MaxLength, out string apiString)) return;
			this.APIKeyPart5Input_TextBox.Text = apiString;
		}
	}
}
