using System;
using StatiKani.Source.JSONObjects;


namespace StatiKani.Source.Items {
	public class ItemLevelProgression : ItemBase {

		protected LevelProgressionData levelProgressionData;


		public ItemLevelProgression(ResourceData data) : base(data) { this.levelProgressionData = (LevelProgressionData)data; }


		public DateTime CreatedAt => this.levelProgressionData.data.created_at;
		public int Level => this.levelProgressionData.data.level;
		public DateTime UnlockedAt => this.levelProgressionData.data.unlocked_at ?? new DateTime();
		public DateTime StartedAt => this.levelProgressionData.data.started_at ?? new DateTime();
		public DateTime PassedAt => this.levelProgressionData.data.passed_at ?? new DateTime();
		public DateTime CompletedAt => this.levelProgressionData.data.completed_at ?? new DateTime();
		public DateTime AbandonedAt => this.levelProgressionData.data.abandoned_at ?? new DateTime();
	}
}
