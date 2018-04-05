using System;
using System.Web.Script.Serialization;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemBase {

		protected ResourceData data;


		public ItemBase(ResourceData data) { this.data = data; }


		public bool HasID => this.data.id >= 0;
		public int ID => this.data.id;
		public string ObjectType => this.data.Object;
		public string Url => this.data.url;
		public DateTime DataUpdatedAt => this.data.data_updated_at;

		public static ItemBase ItemFactory(EJsonDataObjectType jsonDataObjectType, string data) {
			switch (jsonDataObjectType) {
				case EJsonDataObjectType.User: return new ItemUser(new JavaScriptSerializer().Deserialize<UserData>(data));
				case EJsonDataObjectType.Subjects: return new ItemSubject(new JavaScriptSerializer().Deserialize<SubjectData>(data));
				case EJsonDataObjectType.Assignments: return new ItemAssignment(new JavaScriptSerializer().Deserialize<AssignmentData>(data));
				case EJsonDataObjectType.ReviewStatistics: return new ItemReviewStatistics(new JavaScriptSerializer().Deserialize<ReviewStatisticData>(data));
				case EJsonDataObjectType.StudyMaterials: return new ItemStudyMaterial(new JavaScriptSerializer().Deserialize<StudyMaterialData>(data));
				case EJsonDataObjectType.Summary: return new ItemSummary(new JavaScriptSerializer().Deserialize<SummaryData>(data));
				case EJsonDataObjectType.Reviews: return new ItemReview(new JavaScriptSerializer().Deserialize<ReviewData>(data));
				case EJsonDataObjectType.LevelProgression: return new ItemLevelProgression(new JavaScriptSerializer().Deserialize<LevelProgressionData>(data));
				case EJsonDataObjectType.Resets: return new ItemReset(new JavaScriptSerializer().Deserialize<ResetData>(data));
				default: throw new ArgumentOutOfRangeException(nameof(jsonDataObjectType), jsonDataObjectType, null);
			}
		}
	}
}
