using System;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemBase<DataType> {

		protected ResourceData<DataType> data;


		public ItemBase(ResourceData<DataType> data) { this.data = data; }


		public bool HasID => this.data.id >= 0;
		public int ID => this.data.id;
		public string ObjectType => this.data.Object;
		public string Url => this.data.url;
		public DateTime DataUpdatedAt => this.data.data_updated_at;
	}
}
