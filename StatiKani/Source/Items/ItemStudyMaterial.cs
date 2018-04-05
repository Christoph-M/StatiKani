using System;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemStudyMaterial : ItemBase {

		protected StudyMaterialData studyMaterialData;


		public ItemStudyMaterial(ResourceData data) : base(data) { this.studyMaterialData = (StudyMaterialData)data; }


		public DateTime CreatedAt => this.studyMaterialData.data.created_at;
		public int SubjectId => this.studyMaterialData.data.subject_id;
		public string SubjectType => this.studyMaterialData.data.subject_type;
		public string MeaningNote => this.studyMaterialData.data.meaning_note;
		public string ReadingNote => this.studyMaterialData.data.reading_note;
		public string[] MeaningSynonyms => this.studyMaterialData.data.meaning_synonyms;
		public bool Hidden => this.studyMaterialData.data.hidden;
	}
}
