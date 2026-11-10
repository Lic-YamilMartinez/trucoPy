using System;
using System.Collections.Generic;

namespace TrucoPy.Core
{
    public enum Suit { Espadas, Bastos, Oros, Copas }

    [Serializable]
    public struct SpanishCard
    {
        public Suit Suit;
        public int Rank;

        public SpanishCard(Suit suit, int rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString() => Rank + " de " + Suit;
    }

    public static class SpanishDeck
    {
        private static readonly int[] Ranks = { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };

        public static List<SpanishCard> Create40()
        {
            var cards = new List<SpanishCard>(40);
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                foreach (int rank in Ranks)
                    cards.Add(new SpanishCard(suit, rank));
            return cards;
        }

        public static void Shuffle<T>(IList<T> items, Random random)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            if (random == null) throw new ArgumentNullException(nameof(random));
            for (int i = items.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                T temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        }
    }
}
