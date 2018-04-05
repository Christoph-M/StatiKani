using StatiKani.Source.Items.SubItems;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemSubjectVocabulary : ItemSubject {
		public ItemSubjectVocabulary(SubjectData data) : base(data) { }


		public int ReadingCount => this.subjectData.data.readings.Length;
		public SubItemReading ReadingAt(int i) => new SubItemReading(this.subjectData.data.readings[i]);
		public string[] PartsOfSpeech => this.subjectData.data.parts_of_speech;
		public int[] SubjectComponentIDs => this.subjectData.data.subject_component_ids;
	}
}
