using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace kofemachina
{
    public class Drink
    {
        //public Color Color { protected set; get; }
        public string Name { protected set; get; }
        public int Cost { protected set; get; }
        public int Time { protected set; get; }
        public bool Sugar { protected set; get; }
        public bool Strong { protected set; get; }
        public bool Cream { protected set; get; }
        public bool Milk { protected set; get; }

        public Drink() { }

        protected Drink(string name, int cost, int time = 5)
        {
            Name = name;
            Cost = cost;
            Time = time;
        }

        public Drink(
            string name, int cost, int time = 5, bool sugar = false, 
            bool strong = false, bool cream = false, bool milk = false) 
        {
            Name = name;
            Cost = cost;
            Time = time;
            Sugar = sugar;
            Strong = strong;
            Cream = cream;
            Milk = milk;
            //Color = color;
        }
    }
}
