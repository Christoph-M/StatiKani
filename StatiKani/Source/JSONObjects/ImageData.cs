using System.Windows.Media;


namespace StatiKani.Source.JSONObjects {
	class ImageData {
		public class MetaData {
			public Color color = new Color();
			public string dimensions = null;
			public string style_name = null;
			public bool inline_styles = false;
		}

		public string url = null;
		public MetaData metadata = null;
		public string content_type = null;
	}
}
