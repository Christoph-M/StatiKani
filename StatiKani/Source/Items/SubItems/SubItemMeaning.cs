using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items.SubItems {
	public class SubItemMeaning : SubItemBase<MeaningData> {
		public SubItemMeaning(MeaningData data) : base(data) { }


		public string Meaning => this.data.meaning;
		public bool Primary => this.data.primary;
	}
}
