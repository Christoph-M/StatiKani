using System;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemReviewStatistics : ItemBase {

		protected ReviewStatisticData reviewStatisticData;


		public ItemReviewStatistics(ResourceData data) : base(data) { this.reviewStatisticData = (ReviewStatisticData)data; }


		public DateTime CreatedAt => this.reviewStatisticData.data.created_at;
		public int SubjectId => this.reviewStatisticData.data.subject_id;
		public string SubjectType => this.reviewStatisticData.data.subject_type;
		public int MeaningCorrect => this.reviewStatisticData.data.meaning_correct;
		public int MeaningIncorrect => this.reviewStatisticData.data.meaning_incorrect;
		public int MeaningMaxStreak => this.reviewStatisticData.data.meaning_max_streak;
		public int MeaningCurrentStreak => this.reviewStatisticData.data.meaning_current_streak;
		public int ReadingCorrect => this.reviewStatisticData.data.reading_correct;
		public int ReadingIncorrect => this.reviewStatisticData.data.reading_incorrect;
		public int ReadingMaxStreak => this.reviewStatisticData.data.reading_max_streak;
		public int ReadingCurrentStreak => this.reviewStatisticData.data.reading_current_streak;
		public int PercentageCorrect => this.reviewStatisticData.data.percentage_correct;
		public bool Hidden => this.reviewStatisticData.data.hidden;
	}
}
