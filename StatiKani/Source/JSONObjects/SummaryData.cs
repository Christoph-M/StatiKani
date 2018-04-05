

namespace StatiKani.Source.JSONObjects {
	public class SummaryData : ResourceData {
		public class Data {
			public NextReviewsData[] reviews = null;
			public NextReviewsData[] lessons = null;
		}

		public Data data;
	}
}
