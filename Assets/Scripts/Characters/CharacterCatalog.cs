using System.Collections.Generic;
using TrucoPy.AI;

namespace TrucoPy.Characters
{
    public static class CharacterCatalog
    {
        // Nombres ficticios provisionales; no usan identidad ni imagen de personas reales.
        public static List<BotProfile> CreateDefaults() => new List<BotProfile>
        {
            new BotProfile("don_tomas", "Don Tomás", BotDifficulty.Facil, 0.05f),
            new BotProfile("nana_rosa", "Ña Rosa", BotDifficulty.Normal, 0.15f),
            new BotProfile("capitan_karai", "Capitán Karai", BotDifficulty.Dificil, 0.25f),
            new BotProfile("tio_tere", "Tío Tereré", BotDifficulty.Normal, 0.35f),
            new BotProfile("don_ramiro", "Don Ramiro", BotDifficulty.Dificil, 0.10f)
        };
    }
}
