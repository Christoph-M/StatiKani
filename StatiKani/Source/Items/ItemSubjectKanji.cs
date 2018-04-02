using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemSubjectKanji : ItemSubject {
		public ItemSubjectKanji(ResourceData<SubjectData> data) : base(data) { }


		public ReadingData[] Readings => this.data.data.readings;
		public int[] SubjectComponentIDs => this.data.data.subject_component_ids;
	}
}
