using System;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemUser : ItemBase {

		protected UserData userData;


		public ItemUser(ResourceData data) : base(data) { this.userData = (UserData)data; }


		public string UserName => this.userData.data.username;
		public int Level => this.userData.data.level;
		public int MaxLevelGrantedBySubscription => this.userData.data.max_level_granted_by_subscription;
		public DateTime StartedAt => this.userData.data.started_at;
		public bool IsSubscribed => this.userData.data.subscribed;
		public DateTime CurrentVacationStartedAt => this.userData.data.current_vacation_started_at ?? new DateTime();
	}
}
