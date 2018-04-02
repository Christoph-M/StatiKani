using StatiKani.Source.Items.SubItems;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemSubjectRadical : ItemSubject {
		public ItemSubjectRadical(ResourceData<SubjectData> data) : base(data) { }


		public int CharacterImageCount => this.data.data.character_images.Length;
		public SubItemCharacterImage CharacterImageAt(int i) => new SubItemCharacterImage(this.data.data.character_images[i]);
	}
}
