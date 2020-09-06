using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhaseTen
{
    public class Player
    {
        private List<Card> hand;
        private readonly int playerId;
        private bool yourTurn;
        private bool drewCard;
        private bool discarded;

        public Player(Deck _deck, int _playerId)
        {
            hand = new List<Card>();
            playerId = _playerId;
            yourTurn = false;
            drewCard = false;
            discarded = false;
            for(int i = 0; i < 10; i++)
            {
                hand.Add(_deck.Deal());
            }
        }

        public List<Card> GetHand()
        {
            return hand;
        }

        public void SetTurnTrue()
        {
            yourTurn = true;
        }

        public bool GetTurn()
        {
            return yourTurn;
        }
    }
}