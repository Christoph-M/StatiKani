using System;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemReset : ItemBase {

		protected ResetData resetData;


		public ItemReset(ResourceData data) : base(data) { this.resetData = (ResetData)data; }


		public DateTime CreatedAt => this.resetData.data.created_at;
		public int OriginalLevel => this.resetData.data.original_level;
		public int TargetLevel => this.resetData.data.target_level;
		public DateTime ConfirmedAt => this.resetData.data.confirmed_at;
	}
}
