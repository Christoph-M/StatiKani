using System;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items.SubItems {
	public class SubItemNextReview : SubItemBase<NextReviewsData> {
		public SubItemNextReview(NextReviewsData data) : base(data) { }


		public DateTime AvailableAt => this.data.available_at;
		public int[] SubjectIds => this.data.subject_ids;
	}
}
