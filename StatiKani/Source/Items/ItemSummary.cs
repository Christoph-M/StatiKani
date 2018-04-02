using System;
using StatiKani.Source.Items.SubItems;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemSummary : ItemBase<SummaryData> {
		public ItemSummary(ResourceData<SummaryData> data) : base(data) { }


		public int ReviewCount => this.data.data.reviews.Length;
		public int LessonCount => this.data.data.lessons.Length;
		public SubItemNextReview ReviewAt(int i) => new SubItemNextReview(this.data.data.reviews[i]);
		public SubItemNextReview LessonAt(int i) => new SubItemNextReview(this.data.data.lessons[i]);
	}
}
