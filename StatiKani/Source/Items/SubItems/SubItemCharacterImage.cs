using System;
using System.Windows;
using System.Windows.Media;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items.SubItems {
	public class SubItemCharacterImage : SubItemBase<ImageData> {

		protected Point dimensions;


		public SubItemCharacterImage(ImageData data) : base(data) {
			string[] subStrings = data.metadata.dimensions.Split(new [] { 'x' }, StringSplitOptions.RemoveEmptyEntries);
			if (subStrings.Length < 2) return;
			this.dimensions.X = int.Parse(subStrings[0]);
			this.dimensions.Y = int.Parse(subStrings[1]);
		}


		public string Url => this.data.url;
		public Color Color => this.data.metadata.color;
		public Point Dimensions => this.dimensions;
		public string StyleName => this.data.metadata.style_name;
		public bool InlineStyles => this.data.metadata.inline_styles;
		public string ContentType => this.data.content_type;
	}
}
