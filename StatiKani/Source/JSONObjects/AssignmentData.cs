using System;


namespace StatiKani.Source.JSONObjects {
	public class AssignmentData {
		public DateTime created_at = new DateTime();
		public int subject_id = -1;
		public string subject_type = null;
		public int level = -1;
		public int srs_stage = -1;
		public string srs_stage_name = null;
		public DateTime? unlocked_at = new DateTime();
		public DateTime? started_at = new DateTime();
		public DateTime? passed_at = new DateTime();
		public DateTime? burned_at = new DateTime();
		public DateTime? available_at = new DateTime();
		public DateTime? resurrected_at = new DateTime();
		public bool passed = false;
		public bool resurrected = false;
		public bool hidden = false;
	}
}
