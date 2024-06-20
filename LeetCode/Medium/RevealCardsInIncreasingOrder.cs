using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    internal class RevealCardsInIncreasingOrder
    {
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            Array.Sort(deck);
            Queue<int> queueDeck = new Queue<int>(Enumerable.Range(0, deck.Length));
            int[] result = new int[deck.Length];

            foreach (var card in deck)
            {
                result[queueDeck.Dequeue()] = card;
                if(queueDeck.Count>0)
                    queueDeck.Enqueue(queueDeck.Dequeue());
            }

            return result;
        }
    }
}
