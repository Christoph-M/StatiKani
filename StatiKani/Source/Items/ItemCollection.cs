using System;
using System.Web.Script.Serialization;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemCollection {

		protected CollectionData collection;
		protected ItemBase[] datas;


		public ItemCollection(CollectionData collection, EJsonDataObjectType jsonDataObjectType) {
			this.collection = collection;

			switch (jsonDataObjectType) {
				case EJsonDataObjectType.Subjects: {
					SubjectCollectionData subjectCollection = (SubjectCollectionData)collection;
					this.datas = new ItemBase[subjectCollection.data.Length];
					for (int i = 0; i < this.datas.Length; ++i) {
						this.datas[i] = new ItemSubject(subjectCollection.data[i]);
					}
				} break;
				case EJsonDataObjectType.Assignments: {
					AssignmentCollectionData assignmentCollection = (AssignmentCollectionData)collection;
					this.datas = new ItemBase[assignmentCollection.data.Length];
					for (int i = 0; i < this.datas.Length; ++i) {
						this.datas[i] = new ItemAssignment(assignmentCollection.data[i]);
					}
				} break;
				case EJsonDataObjectType.ReviewStatistics: {
					ReviewStatisticCollectionData reviewStatisticCollection = (ReviewStatisticCollectionData)collection;
					this.datas = new ItemBase[reviewStatisticCollection.data.Length];
					for (int i = 0; i < this.datas.Length; ++i) {
						this.datas[i] = new ItemReviewStatistics(reviewStatisticCollection.data[i]);
					}
				} break;
				case EJsonDataObjectType.StudyMaterials: {
					StudyMaterialCollectionData studyMaterialCollection = (StudyMaterialCollectionData)collection;
					this.datas = new ItemBase[studyMaterialCollection.data.Length];
					for (int i = 0; i < this.datas.Length; ++i) {
						this.datas[i] = new ItemStudyMaterial(studyMaterialCollection.data[i]);
					}
				} break;
				case EJsonDataObjectType.Reviews: {
					ReviewCollectionData reviewCollection = (ReviewCollectionData)collection;
					this.datas = new ItemBase[reviewCollection.data.Length];
					for (int i = 0; i < this.datas.Length; ++i) {
						this.datas[i] = new ItemReview(reviewCollection.data[i]);
					}
				} break;
				case EJsonDataObjectType.LevelProgression: {
					LevelProgressionCollectionData levelProgressionCollection = (LevelProgressionCollectionData)collection;
					this.datas = new ItemBase[levelProgressionCollection.data.Length];
					for (int i = 0; i < this.datas.Length; ++i) {
						this.datas[i] = new ItemLevelProgression(levelProgressionCollection.data[i]);
					}
				} break;
				case EJsonDataObjectType.Resets: {
					ResetCollectionData resetCollection = (ResetCollectionData)collection;
					this.datas = new ItemBase[resetCollection.data.Length];
					for (int i = 0; i < this.datas.Length; ++i) {
						this.datas[i] = new ItemReset(resetCollection.data[i]);
					}
				} break;
				default: throw new ArgumentOutOfRangeException(nameof(jsonDataObjectType), jsonDataObjectType, null);
			}
		}


		public string Url => this.collection.url;
		public string NextUrl => this.collection.pages.next_url;
		public string PreviousUrl => this.collection.pages.previous_url;
		public int PerPage => this.collection.pages.per_page;
		public int TotalCount => this.collection.total_count;
		public DateTime DataUpdatedAt => this.collection.data_updated_at;
		public ItemBase[] ItemData => this.datas;

		public static ItemCollection CollectionFactory(EJsonDataObjectType jsonDataObjectType, string data) {
			switch (jsonDataObjectType) {
				case EJsonDataObjectType.Subjects: return new ItemCollection(new JavaScriptSerializer().Deserialize<SubjectCollectionData>(data), jsonDataObjectType);
				case EJsonDataObjectType.Assignments: return new ItemCollection(new JavaScriptSerializer().Deserialize<AssignmentCollectionData>(data), jsonDataObjectType);
				case EJsonDataObjectType.ReviewStatistics: return new ItemCollection(new JavaScriptSerializer().Deserialize<ReviewStatisticCollectionData>(data), jsonDataObjectType);
				case EJsonDataObjectType.StudyMaterials: return new ItemCollection(new JavaScriptSerializer().Deserialize<StudyMaterialCollectionData>(data), jsonDataObjectType);
				case EJsonDataObjectType.Reviews: return new ItemCollection(new JavaScriptSerializer().Deserialize<ReviewCollectionData>(data), jsonDataObjectType);
				case EJsonDataObjectType.LevelProgression: return new ItemCollection(new JavaScriptSerializer().Deserialize<LevelProgressionCollectionData>(data), jsonDataObjectType);
				case EJsonDataObjectType.Resets: return new ItemCollection(new JavaScriptSerializer().Deserialize<ResetCollectionData>(data), jsonDataObjectType);
				default: throw new ArgumentOutOfRangeException(nameof(jsonDataObjectType), jsonDataObjectType, null);
			}
		}
	}
}