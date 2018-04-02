using System;


namespace StatiKani.Source.JSONObjects {
	class CollectionData<DataType> {
		public string Object = null;
		public string url = null;
		public PagesData pages = new PagesData();
		public int total_count = -1;
		public DateTime data_updated_at = new DateTime();
		public DataType[] data = new DataType[0];
	}
}
