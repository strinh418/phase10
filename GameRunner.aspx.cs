using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhaseTen
{
    public partial class GameRunner : System.Web.UI.Page
    {
        GameBoard phaseTen = new GameBoard(3);
        protected void Page_Load(object sender, EventArgs e)
        {
            phaseTen.StartGame();
            PaintDiscardedPile(phaseTen);
            PaintHand(phaseTen.GetPlayer(1).GetHand());
            Session["PlayerId"] = 1;
            if(Session["Hand"] != null)
            {
                Session["Hand"] = phaseTen.GetPlayer(1).GetHand();
            }
        }
        public void PaintCard(Card _card, Image _image)
        {
            if(_card.GetCardType().Equals("Wild"))
            {
                _image.ImageUrl = "Cards/Wild.png";
            } else if(_card.GetCardType().Equals("Skip"))
            {
                _image.ImageUrl = "Cards/Skip.png";
            } else
            {
                _image.ImageUrl = "Cards/" + _card.GetCardColor() + _card.GetCardValue().ToString() + ".png";
            }
        }
        public void PaintDiscardedPile(GameBoard _gameBoard)
        {
            List<Card> discardPile = _gameBoard.GetDiscardPile();
            if(discardPile.Count > 0)
            {
                Card currentDiscarded = discardPile[discardPile.Count - 1];
                PaintCard(currentDiscarded, DiscardedPile);
            } else
            {
                DiscardedPile.Visible = false;
            }
        }
        public void PaintHand(List<Card> hand)
        {
            PaintCard(hand[0], Card1);
            PaintCard(hand[1], Card2);
            PaintCard(hand[2], Card3);
            PaintCard(hand[3], Card4);
            PaintCard(hand[4], Card5);
            PaintCard(hand[5], Card6);
            PaintCard(hand[6], Card7);
            PaintCard(hand[7], Card8);
            PaintCard(hand[8], Card9);
            PaintCard(hand[9], Card10);
        }

        protected void DiscardedPile_Click(object sender, ImageClickEventArgs e)
        {
            PaintHand((List<Card>)(Session["Hand"]));
            /*Player curPlayer = phaseTen.GetPlayer(1);
            int disIndex = phaseTen.GetDiscardPile().Count - 1;
            Card discarded = phaseTen.GetDiscardPile()[disIndex];
            if(phaseTen.GetPlayer(1).GetTurn())
            {
                curPlayer.GetHand().Add(discarded);
                phaseTen.GetDiscardPile().RemoveAt(disIndex);
                PaintDiscardedPile(phaseTen);
                PaintCard(curPlayer.GetHand()[10], Card11);
            }*/
        }
    }
}