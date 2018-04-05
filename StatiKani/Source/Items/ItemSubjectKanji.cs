using StatiKani.Source.Items.SubItems;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemSubjectKanji : ItemSubject {
		public ItemSubjectKanji(SubjectData data) : base(data) { }


		public int ReadingCount => this.subjectData.data.readings.Length;
		public SubItemReading ReadingAt(int i) => new SubItemReading(this.subjectData.data.readings[i]);
		public int[] SubjectComponentIDs => this.subjectData.data.subject_component_ids;
	}
}
