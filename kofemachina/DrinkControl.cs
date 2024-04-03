using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kofemachina
{
    public partial class DrinkControl : UserControl
    {
        private Drink dr = new Drink();
        public Drink Dr {
            set
            {
                dr = value;
                labelName.Text = dr.Name;
                labelCost.Text = dr.Cost.ToString();
            }
            get
            {
                return dr;
            }
        }
        public DrinkControl()
        {
            InitializeComponent();
        }

        private void DrinkControl_Load(object sender, EventArgs e)
        {
            //labelName.Text = dr.Name;
        }

        private void DrinkControl_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void DrinkControl_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
