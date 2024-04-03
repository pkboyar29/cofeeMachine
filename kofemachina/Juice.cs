using System;
using System.Collections.Generic;
using System.Text;

namespace kofemachina
{
    internal class Juice : Drink
    {
        public Juice(string name, int cost, int time = 5) : base(name, cost, time)
        {
            Strong = false;
            Milk = false;
            Sugar = false;
            Cream = false;
        }
    }
}
