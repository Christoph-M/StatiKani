using System;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemLevelProgression : ItemBase<LevelProgressionData> {
		public ItemLevelProgression(ResourceData<LevelProgressionData> data) : base(data) { }


		public DateTime CreatedAt => this.data.data.created_at;
		public int Level => this.data.data.level;
		public DateTime UnlockedAt => this.data.data.unlocked_at ?? new DateTime();
		public DateTime StartedAt => this.data.data.started_at ?? new DateTime();
		public DateTime PassedAt => this.data.data.passed_at ?? new DateTime();
		public DateTime CompletedAt => this.data.data.completed_at ?? new DateTime();
		public DateTime AbandonedAt => this.data.data.abandoned_at ?? new DateTime();
	}
}
