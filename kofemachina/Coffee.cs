using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace kofemachina
{
    internal class Coffee : Drink
    {
        public Coffee(string name, int cost, int time = 5) : base(name, cost, time)
        {
            Strong = true;
            Milk = true;
            Sugar = true;
            Cream = true;
        }
    }
}
