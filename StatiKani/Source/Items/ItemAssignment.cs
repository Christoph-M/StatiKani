using System;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemAssignment : ItemBase<AssignmentData> {
		public ItemAssignment(ResourceData<AssignmentData> data) : base(data) { }


		public DateTime CreatedAt => this.data.data.created_at;
		public int SubjectId => this.data.data.subject_id;
		public string SubjectType => this.data.data.subject_type;
		public int Level => this.data.data.level;
		public int SrsStage => this.data.data.srs_stage;
		public string SrsStageName => this.data.data.srs_stage_name;
		public DateTime UnlockedAt => this.data.data.unlocked_at ?? new DateTime();
		public DateTime StartedAt => this.data.data.started_at ?? new DateTime();
		public DateTime PassedAt => this.data.data.passed_at ?? new DateTime();
		public DateTime BurnedAt => this.data.data.burned_at ?? new DateTime();
		public DateTime AvailableAt => this.data.data.available_at ?? new DateTime();
		public DateTime ResurrectedAt => this.data.data.resurrected_at ?? new DateTime();
		public bool Passed => this.data.data.passed;
		public bool Resurrected => this.data.data.resurrected;
		public bool Hidden => this.data.data.hidden;
	}
}
