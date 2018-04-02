using System;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemReviewStatistics : ItemBase<ReviewStatisticData> {
		public ItemReviewStatistics(ResourceData<ReviewStatisticData> data) : base(data) { }


		public DateTime CreatedAt => this.data.data.created_at;
		public int SubjectId => this.data.data.subject_id;
		public string SubjectType => this.data.data.subject_type;
		public int MeaningCorrect => this.data.data.meaning_correct;
		public int MeaningIncorrect => this.data.data.meaning_incorrect;
		public int MeaningMaxStreak => this.data.data.meaning_max_streak;
		public int MeaningCurrentStreak => this.data.data.meaning_current_streak;
		public int ReadingCorrect => this.data.data.reading_correct;
		public int ReadingIncorrect => this.data.data.reading_incorrect;
		public int ReadingMaxStreak => this.data.data.reading_max_streak;
		public int ReadingCurrentStreak => this.data.data.reading_current_streak;
		public int PercentageCorrect => this.data.data.percentage_correct;
		public bool Hidden => this.data.data.hidden;
	}
}
