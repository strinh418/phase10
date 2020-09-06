using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhaseTen
{
    public class GameBoard
    {
        private readonly int numPlayers;
        private readonly Player[] players;
        private Deck deck;
        private List<Card> discardPile;
        private static readonly String[] colors = {"Blue", "Green", "Red", "Yellow"};
        private static readonly int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        private int startingPlayer;

        public GameBoard(int _numPlayers)
        {
            numPlayers = _numPlayers;
            startingPlayer = 1;
            deck = new Deck(colors, values);
            discardPile = new List<Card>();
            players = new Player[numPlayers];

        }

        public void StartGame()
        {
            for (int i = 0; i < 1; i++) // First, shuffle the deck
            {
                deck.Shuffle();
            }
            for (int i = 0; i < players.Count(); i++) // Then, deal to players
            {
                players[i] = new Player(deck, i+1);
            }
            discardPile.Add(deck.Deal()); // Places the first card on the discard pile
            players[startingPlayer].SetTurnTrue();
        }

        public Deck GetDeck()
        {
            return deck;
        }

        public Player GetPlayer(int num)
        {
            return players[num];
        }

        public List<Card> GetDiscardPile()
        {
            return discardPile;
        }
    }

   
    
    
}