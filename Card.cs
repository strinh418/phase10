using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhaseTen
{
    public class Card
    {
        private readonly String type;
        private readonly String color;
        private readonly int value;

        public Card(String _type, String _color, int _value)
        {
            type = _type;
            color = _color;
            value = _value;
        }

        public String GetCardType()
        {
            return type;
        }

        public String GetCardColor()
        {
            return color;
        }

        public int GetCardValue()
        {
            return value;
        }
        public override String ToString()
        {
            return "Type: " + type + ", Color: " + color + ", Value: " + value;
        }

    }
}