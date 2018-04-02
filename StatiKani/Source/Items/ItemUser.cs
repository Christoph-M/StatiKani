using System;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemUser : ItemBase<UserData> {
		public ItemUser(ResourceData<UserData> data) : base(data) { }


		public string UserName => this.data.data.username;
		public int Level => this.data.data.level;
		public int MaxLevelGrantedBySubscription => this.data.data.max_level_granted_by_subscription;
		public DateTime StartedAt => this.data.data.started_at;
		public bool IsSubscribed => this.data.data.subscribed;
		public DateTime CurrentVacationStartedAt => data.data.current_vacation_started_at ?? new DateTime();
	}
}
