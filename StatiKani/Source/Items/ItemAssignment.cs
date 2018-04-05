using System;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemAssignment : ItemBase {

		protected AssignmentData assignmentData;


		public ItemAssignment(ResourceData data) : base(data) { this.assignmentData = (AssignmentData)data; }


		public DateTime CreatedAt => this.assignmentData.data.created_at;
		public int SubjectId => this.assignmentData.data.subject_id;
		public string SubjectType => this.assignmentData.data.subject_type;
		public int Level => this.assignmentData.data.level;
		public int SrsStage => this.assignmentData.data.srs_stage;
		public string SrsStageName => this.assignmentData.data.srs_stage_name;
		public DateTime UnlockedAt => this.assignmentData.data.unlocked_at ?? new DateTime();
		public DateTime StartedAt => this.assignmentData.data.started_at ?? new DateTime();
		public DateTime PassedAt => this.assignmentData.data.passed_at ?? new DateTime();
		public DateTime BurnedAt => this.assignmentData.data.burned_at ?? new DateTime();
		public DateTime AvailableAt => this.assignmentData.data.available_at ?? new DateTime();
		public DateTime ResurrectedAt => this.assignmentData.data.resurrected_at ?? new DateTime();
		public bool Passed => this.assignmentData.data.passed;
		public bool Resurrected => this.assignmentData.data.resurrected;
		public bool Hidden => this.assignmentData.data.hidden;
	}
}
