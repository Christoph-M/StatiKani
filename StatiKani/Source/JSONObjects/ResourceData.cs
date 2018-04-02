using System;


namespace StatiKani.Source.JSONObjects {
	class ResourceData<DataType> {
		public int id = -1;
		public string Object = null;
		public string url = null;
		public DateTime data_updated_at = new DateTime();
		public DataType data;
	}
}
