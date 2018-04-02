using System;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemStudyMaterial : ItemBase<StudyMaterialData> {
		public ItemStudyMaterial(ResourceData<StudyMaterialData> data) : base(data) { }


		public DateTime CreatedAt => this.data.data.created_at;
		public int SubjectId => this.data.data.subject_id;
		public string SubjectType => this.data.data.subject_type;
		public string MeaningNote => this.data.data.meaning_note;
		public string ReadingNote => this.data.data.reading_note;
		public string[] MeaningSynonyms => this.data.data.meaning_synonyms;
		public bool Hidden => this.data.data.hidden;
	}
}
