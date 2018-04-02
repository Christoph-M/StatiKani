using System;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemSubject : ItemBase<SubjectData> {
		public ItemSubject(ResourceData<SubjectData> data) : base(data) { }


		public int Level => this.data.data.level;
		public DateTime CreatedAt => this.data.data.created_at;
		public string Characters => this.data.data.characters;
		public MeaningData[] Meanings => this.data.data.meanings;
		public string DocumentUrl => this.data.data.document_url;
		public DateTime HiddenAt => this.data.data.hidden_at ?? new DateTime();
	}
}
