using System;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemReview : ItemBase {

		protected ReviewData reviewData;


		public ItemReview(ResourceData data) : base(data) { this.reviewData = (ReviewData)data; }


		public DateTime CreatedAt => this.reviewData.data.created_at;
		public int AssignmentId => this.reviewData.data.assignment_id;
		public int SubjectId => this.reviewData.data.subject_id;
		public int StartingSrsStage => this.reviewData.data.starting_srs_stage;
		public string StartingSesStageName => this.reviewData.data.starting_srs_stage_name;
		public int EndingSrsStage => this.reviewData.data.ending_srs_stage;
		public string EndingSrsStageName => this.reviewData.data.ending_srs_stage_name;
		public int IncorrectMeaningAnswers => this.reviewData.data.incorrect_meaning_answers ?? 0;
		public int IncorrectReadingAnswers => this.reviewData.data.incorrect_reading_answers ?? 0;
	}
}
