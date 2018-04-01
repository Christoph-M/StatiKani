using System;


namespace StatiKani.Source.JSONObjects {
	class Subject {
		public int level = -1;
		public DateTime created_at = new DateTime();
		public string characters = null;
		public object[] character_images = null;    //TODO: determin object
		public object[] meanings = null;			//TODO: determin object
		public object[] readings = null;			//TODO: determin object
		public string[] parts_of_speech = null;
		public int[] subject_component_ids = null;
		public string document_url = null;
		public DateTime? hidden_at = new DateTime();
	}
}
