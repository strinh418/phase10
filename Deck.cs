using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhaseTen
{
    public class Deck
    {
        private List<Card> cards;
        private int size;
        private bool isEmpty;

        public Deck(String[] colors, int[] values)
        {
            cards = new List<Card>();
            isEmpty = false;
            for (int i = 0; i < 8; i++)
            {
                cards.Add(new Card("Wild", "None", 25));
                if (i % 2 == 0)
                {
                    cards.Add(new Card("Skip", "None", 15));
                }
            }
            for (int i = 0; i < colors.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    cards.Add(new Card("Number", colors[i], values[j]));
                    cards.Add(new Card("Number", colors[i], values[j]));
                }
            }
            size = cards.Count;
        }

        public void Shuffle()
        {
            Card temp;
            Random r = new Random();
            int ranNum;
            for(int i = cards.Count - 1; i >= 0; i--)
            {
                ranNum = r.Next(0, i);
                temp = cards[ranNum];
                cards[ranNum] = cards[i];
                cards[i] = temp;
            }
            /*for (int i = cards.Count - 1; i > 0; i--)
            {
                int howMany = i + 1;
                Random rand = new Random();
                int randPos = rand.Next(0, howMany);
                Card temp = (Card)cards[i];
                cards[i] = cards[randPos];
                cards[randPos] = temp;
            }*/
        }

        public Card Deal()
        {
            if(isEmpty)
            {
                return null;
            }
            size--;
            Card c = cards[size];
            return c;
        }
        
        public int GetSize()
        {
            return size;
        }

        public List<Card> GetCards()
        {
            return cards;
        }

    }
}