using System;


namespace StatiKani.Source.JSONObjects {
	class StudyMaterial {
		public DateTime created_at = new DateTime();
		public int subject_id = -1;
		public string subject_type = null;
		public string meaning_note = null;
		public string reading_note = null;
		public string[] meaning_synonyms = null;
		public bool hidden = false;
	}
}
