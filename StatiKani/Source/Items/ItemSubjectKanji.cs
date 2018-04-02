using StatiKani.Source.Items.SubItems;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemSubjectKanji : ItemSubject {
		public ItemSubjectKanji(ResourceData<SubjectData> data) : base(data) { }


		public int ReadingCount => this.data.data.readings.Length;
		public SubItemReading ReadingAt(int i) => new SubItemReading(this.data.data.readings[i]);
		public int[] SubjectComponentIDs => this.data.data.subject_component_ids;
	}
}
