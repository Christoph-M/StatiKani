using System;


namespace StatiKani.Source.JSONObjects {
	public class CollectionData {
		public string Object = null;
		public string url = null;
		public PagesData pages = new PagesData();
		public int total_count = -1;
		public DateTime data_updated_at = new DateTime();
	}
}
