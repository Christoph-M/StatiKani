using System;


namespace StatiKani.Source.JSONObjects {
	class ReviewStatisticData {
		public DateTime created_at = new DateTime();
		public int subject_id = -1;
		public string subject_type = null;
		public int meaning_correct = -1;
		public int meaning_incorrect = -1;
		public int meaning_max_streak = -1;
		public int meaning_current_streak = -1;
		public int reading_correct = -1;
		public int reading_incorrect = -1;
		public int reading_max_streak = -1;
		public int reading_current_streak = -1;
		public int percentage_correct = -1;
		public bool hidden = false;
	}
}
