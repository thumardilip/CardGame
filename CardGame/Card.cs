using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Card
    {
        public Suit suite { get; set; }
        public string value { get; set; }
        public Card(Suit s, string v)
        {
            suite = s;
            value = v;
        }
    }
}
