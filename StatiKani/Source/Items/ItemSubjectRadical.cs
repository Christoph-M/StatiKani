using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemSubjectRadical : ItemSubject {
		public ItemSubjectRadical(ResourceData<SubjectData> data) : base(data) { }


		public ImageData[] CharacterImages => this.data.data.character_images;
	}
}
