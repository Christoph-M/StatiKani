

namespace StatiKani.Source.JSONObjects {
	public enum EJsonDataObjectType {
		Unknown,
		User,
		Subjects,
		Assignments,
		ReviewStatistics,
		StudyMaterials,
		Summary,
		Reviews,
		LevelProgressions,
		Resets
	}

	public static class RequestEndPoint {
		public static string User = "user";
		public static string Subjects = "subjects";
		public static string Assignments = "assignments";
		public static string ReviewStatistics = "review_statistics";
		public static string StudyMaterials = "study_material";
		public static string Summary = "summary";
		public static string Reviews = "reviews";
		public static string LevelProgressions = "level_progressions";
		public static string Resets = "Resets";
	}
}
