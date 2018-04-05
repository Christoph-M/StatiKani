using StatiKani.Source.Items.SubItems;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemSummary : ItemBase {

		protected SummaryData summaryData;


		public ItemSummary(ResourceData data) : base(data) { this.summaryData = (SummaryData)data; }


		public int ReviewCount => this.summaryData.data.reviews.Length;
		public int LessonCount => this.summaryData.data.lessons.Length;
		public SubItemNextReview ReviewAt(int i) => new SubItemNextReview(this.summaryData.data.reviews[i]);
		public SubItemNextReview LessonAt(int i) => new SubItemNextReview(this.summaryData.data.lessons[i]);
	}
}
