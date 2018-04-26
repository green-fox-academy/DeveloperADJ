using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Poker
{
    public class Card
    {
        public int Value { get; set; }
        public char Suit { get; set; }

        public Card(int value, char suit)
        {
            Value = value;
            Suit = suit;
        }

        //Black: 2H 3D 5S 9C KD White: 2C 3H 4S 8C AH
        public static (List<Card>, List<Card>) CreateHandsFromString(string hands)
        {
            List<string> splittedHands = hands.Split(' ').ToList();

            splittedHands.RemoveAt(0);
            splittedHands.RemoveAt(5);

            List<Card> BlackHand = new List<Card>();
            List<Card> WhiteHand = new List<Card>();

            for (int i = 0; i < splittedHands.Count; i++)
            {
                if (i <= 4)
                {
                    BlackHand.Add(CreateCardFromString(splittedHands[i]));
                }
                else
                {
                    WhiteHand.Add(CreateCardFromString(splittedHands[i]));
                }
            }

            return (BlackHand, WhiteHand);
        }

        public static Card CreateCardFromString(string cardString = "1C")
        {
            int _value = 0;

            if (cardString.Length == 3)
            {
                _value = Convert.ToInt32(cardString[0].ToString() + cardString[1].ToString());
            }
            else
            {
                try
                {
                    _value = Convert.ToInt32(cardString[0].ToString());
                }
                catch
                {
                    if (cardString[0] == 'A')
                    {
                        _value = 14;
                    }
                    else if (cardString[0] == 'J')
                    {
                        _value = 11;
                    }
                    else if (cardString[0] == 'Q')
                    {
                        _value = 12;
                    }
                    else if (cardString[0] == 'K')
                    {
                        _value = 13;
                    }
                }
            }

            char _suit = cardString[1];

            return new Card(_value, _suit);
        }
    }
}
