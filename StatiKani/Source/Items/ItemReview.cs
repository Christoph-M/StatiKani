using System;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemReview : ItemBase<ReviewData> {
		public ItemReview(ResourceData<ReviewData> data) : base(data) { }


		public DateTime CreatedAt => this.data.data.created_at;
		public int AssignmentId => this.data.data.assignment_id;
		public int SubjectId => this.data.data.subject_id;
		public int StartingSrsStage => this.data.data.starting_srs_stage;
		public string StartingSesStageName => this.data.data.starting_srs_stage_name;
		public int EndingSrsStage => this.data.data.ending_srs_stage;
		public string EndingSrsStageName => this.data.data.ending_srs_stage_name;
		public int IncorrectMeaningAnswers => this.data.data.incorrect_meaning_answers ?? 0;
		public int IncorrectReadingAnswers => this.data.data.incorrect_reading_answers ?? 0;
	}
}
