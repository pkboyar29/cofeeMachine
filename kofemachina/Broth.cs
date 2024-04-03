using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace kofemachina
{
    internal class Broth : Drink
    {
        public Broth(string name, int cost, int time = 5) : base(name, cost, time)
        {
            Strong = false;
            Milk = false;
            Sugar = false;
            Cream = false;
        }
    }
}
