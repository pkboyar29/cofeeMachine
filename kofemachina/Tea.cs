using System;
using System.Collections.Generic;
using System.Text;

namespace kofemachina
{
    internal class Tea : Drink
    {
        public Tea(string name, int cost, int time = 5) : base(name, cost, time)
        {
            Strong = true;
            Milk = true;
            Sugar = true;
            Cream = true;
        }
    }
}
