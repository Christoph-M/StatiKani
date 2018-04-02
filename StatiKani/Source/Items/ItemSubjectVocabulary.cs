using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemSubjectVocabulary : ItemSubject {
		public ItemSubjectVocabulary(ResourceData<SubjectData> data) : base(data) { }


		public ReadingData[] Readings => this.data.data.readings;
		public string[] PartsOfSpeech => this.data.data.parts_of_speech;
		public int[] SubjectComponentIDs => this.data.data.subject_component_ids;
	}
}
