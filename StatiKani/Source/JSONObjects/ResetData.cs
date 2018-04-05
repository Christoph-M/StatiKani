﻿using System;


namespace StatiKani.Source.JSONObjects {
	public class ResetData : ResourceData {
		public class Data {
			public DateTime created_at = new DateTime();
			public int original_level = -1;
			public int target_level = -1;
			public DateTime confirmed_at = new DateTime();
		}

		public Data data;
	}
}
