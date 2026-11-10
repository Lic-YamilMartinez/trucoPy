using System;
using System.Collections.Generic;
using TrucoPy.Core;

namespace TrucoPy.AI
{
    // CPU provisional: juega una carta aleatoria de su mano.
    // Se reemplazará por estrategia basada en reglas validadas y estado de ronda.
    public static class BasicCardBot
    {
        public static int ChooseCardIndex(IReadOnlyList<SpanishCard> hand, Random random)
        {
            if (hand == null || hand.Count == 0)
                throw new ArgumentException("La mano debe contener cartas.", nameof(hand));
            if (random == null) throw new ArgumentNullException(nameof(random));
            return random.Next(hand.Count);
        }
    }
}
