using System;
using System.Collections.Generic;
using System.Text;

namespace kofemachina
{
    internal class Cacao : Drink
    {
        public Cacao(string name, int cost, int time = 5) : base(name, cost, time)
        {
            Strong = true;
            Milk = true;
            Sugar = false;
            Cream = true;
        }
    }
}
