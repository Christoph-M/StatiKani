using System;


namespace StatiKani.Source.JSONObjects {
	class Review {
		public DateTime created_at = new DateTime();
		public int assignment_id = -1;
		public int subject_id = -1;
		public int starting_srs_stage = -1;
		public string starting_srs_stage_name = null;
		public int ending_srs_stage = -1;
		public string ending_srs_stage_name = null;
		public int? incorrect_meaning_answers = -1;
		public int? incorrect_reading_answers = -1;
	}
}
