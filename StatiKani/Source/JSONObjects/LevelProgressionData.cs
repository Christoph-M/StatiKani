using System;


namespace StatiKani.Source.JSONObjects {
	public class LevelProgressionData : ResourceData {
		public class Data {
			public DateTime created_at = new DateTime();
			public int level = -1;
			public DateTime? unlocked_at = new DateTime();
			public DateTime? started_at = new DateTime();
			public DateTime? passed_at = new DateTime();
			public DateTime? completed_at = new DateTime();
			public DateTime? abandoned_at = new DateTime();
		}

		public Data data;
	}
}
