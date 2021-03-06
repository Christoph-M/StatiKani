﻿using System;


namespace StatiKani.Source.JSONObjects {
	public class UserData : ResourceData {
		public class Data {
			public string username = null;
			public int level = -1;
			public int max_level_granted_by_subscription = -1;
			public DateTime started_at = new DateTime();
			public bool subscribed = false;
			public DateTime? current_vacation_started_at = new DateTime();
		}

		public Data data;
	}
}
