using System;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemReset : ItemBase<ResetData> {
		public ItemReset(ResourceData<ResetData> data) : base(data) { }


		public DateTime CreatedAt => this.data.data.created_at;
		public int OriginalLevel => this.data.data.original_level;
		public int TargetLevel => this.data.data.target_level;
		public DateTime ConfirmedAt => this.data.data.confirmed_at;
	}
}
