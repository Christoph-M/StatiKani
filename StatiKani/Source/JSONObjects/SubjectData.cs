using System;


namespace StatiKani.Source.JSONObjects {
	public class SubjectData : ResourceData {
		public class Data {
			public int level = -1;
			public DateTime created_at = new DateTime();
			public string characters = null;
			public ImageData[] character_images = null;
			public MeaningData[] meanings = null;
			public ReadingData[] readings = null;
			public string[] parts_of_speech = null; // TODO: Test if decode works
			public int[] subject_component_ids = null; // TODO: Always null?
			public string document_url = null;
			public DateTime? hidden_at = new DateTime();
		}

		public Data data;
	}
}
