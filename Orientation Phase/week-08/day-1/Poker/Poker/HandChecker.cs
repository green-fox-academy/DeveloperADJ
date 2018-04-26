using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public static class HandChecker
    {
        static void CheckWinner(List<Card> blackHand, List<Card> whiteHand)
        {
            CheckForHighCard(blackHand, whiteHand);
        }

        public static string CheckForHighCard(List<Card> blackHand, List<Card> whiteHand)
        {
            List<Card> whiteHandOrdered = whiteHand.OrderByDescending(x => x.Value).ToList();
            List<Card> blackHandOrdered = blackHand.OrderByDescending(x => x.Value).ToList();

            if (whiteHandOrdered[0].Value > blackHandOrdered[0].Value)
            {
                return "White Wins!";
            }
            else if (whiteHandOrdered[0].Value == blackHandOrdered[0].Value)
            {
                return "Draw";
            }
            else
            {
                return "Black Wins!";
            }
        }

        public static Dictionary<int, int> CountDuplicateCardsIn(List<Card> hand)
        {
            Dictionary<int, int> cardCounts = new Dictionary<int, int>();

            foreach (var card in hand)
            {
                cardCounts[card.Value] += 1;
            }

            return cardCounts;
        }
    }
}
