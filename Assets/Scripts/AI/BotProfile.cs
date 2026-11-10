using System;

namespace TrucoPy.AI
{
    public enum BotDifficulty { Facil, Normal, Dificil }

    [Serializable]
    public class BotProfile
    {
        public string Id;
        public string DisplayName;
        public BotDifficulty Difficulty;
        public float BluffProbability;

        public BotProfile(string id, string displayName, BotDifficulty difficulty, float bluffProbability)
        {
            Id = id;
            DisplayName = displayName;
            Difficulty = difficulty;
            BluffProbability = Math.Max(0f, Math.Min(1f, bluffProbability));
        }
    }
}
