using System;
using StatiKani.Source.Items.SubItems;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemSubject : ItemBase {

		protected SubjectData subjectData;


		public ItemSubject(ResourceData data) : base(data) { this.subjectData = (SubjectData)data; }


		public int Level => this.subjectData.data.level;
		public DateTime CreatedAt => this.subjectData.data.created_at;
		public string Characters => this.subjectData.data.characters;
		public int MeaningCount => this.subjectData.data.meanings.Length;
		public SubItemMeaning MeaningAt(int i) => new SubItemMeaning(this.subjectData.data.meanings[i]);
		public string DocumentUrl => this.subjectData.data.document_url;
		public DateTime HiddenAt => this.subjectData.data.hidden_at ?? new DateTime();
	}
}
