using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items.SubItems {
	public class SubItemReading : SubItemBase<ReadingData> {
		public SubItemReading(ReadingData data) : base(data) { }


		public string Type => this.data.type;
		public bool Primary => this.data.primary;
		public string Reading => this.data.reading;
	}
}
