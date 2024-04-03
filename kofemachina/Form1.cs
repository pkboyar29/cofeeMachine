using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kofemachina
{
    public partial class Form1 : Form
    {
        bool afterChoose; // равно true, когда мы нажимаем на какой-то напиток

        int balance = 0;

        Drink coffee = new Coffee("Кофе классический", 65);
        Drink latte = new Coffee("Кофе латте", 70);
        Drink capuchino = new Coffee("Кофе капучино", 70, 6);
        Drink water = new Drink("Вода", 25, 2);
        Drink applejuice = new Juice("Яблочный сок", 45);
        Drink greentea = new Tea("Зелёный чай", 35, 4);
        Drink raspberrytea = new Tea("Малиновый чай", 45, 5);
        Drink broth = new Broth("Бульон", 65, 6);

        Drink drinkCurrent; // текущий выбранный напиток

        public Form1()
        {
            InitializeComponent();
        }

        private void billClick(object sender, EventArgs e)
        {
            if (afterChoose)
            {
                string rub = (sender as Button).Tag.ToString();
                balance += int.Parse(rub);
                labelBalance.Text = "Баланс: " + balance.ToString();
            }
        }

        private void GetChangeClick(object sender, EventArgs e)
        {
            labelChange.Text = "";
            if (balance > 0)
            {
                labelChange.Text = "Выдано " + balance.ToString();
                labelBalance.Text = "Баланс: 0";
                balance = 0;
            }
        }

        private void drinkControlClick(object sender, EventArgs e)
        {
            foreach (DrinkControl drinkControl in Controls.OfType<DrinkControl>())
            {
                if (drinkControl.Tag.ToString() == "1")
                    drinkControl.Enabled = false;
            }
            
            (sender as DrinkControl).BackColor = Color.Yellow;

            afterChoose = true;

            drinkCurrent = (sender as DrinkControl).Dr;

            DrinkOptions(drinkCurrent);
        }

        private void buttonGetDrink_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
                FinishWork();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FinishWork();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Drink[] drinks = { coffee, latte, capuchino, water, applejuice, greentea, raspberrytea, broth };

            int i = drinks.Length;
            foreach (DrinkControl drinkControl in Controls.OfType<DrinkControl>())
            {
                if (drinkControl.Tag.ToString() == "1")
                    drinkControl.Dr = drinks[--i];
            }
        }

        private void buttonCook_Click(object sender, EventArgs e)
        {
            if (afterChoose && balance >= drinkCurrent.Cost && progressBar1.Value != progressBar1.Maximum)
            {
                balance -= drinkCurrent.Cost;
                labelBalance.Text = "Баланс: " + balance.ToString();
                
                labelDrinkReady.Text = "Напиток готовится!";

                progressBar1.BackColor = Color.Red;
                progressBar1.Visible = true;
                progressBar1.Maximum = drinkCurrent.Time;
                timer1.Enabled = true;

                trackBarSugar.Enabled = false;
                trackBarStrong.Enabled = false;
                creamCheckBox.Enabled = false;
                milkCheckBox.Enabled = false;
            }
            else if (afterChoose)
                labelDrinkReady.Text = "Недостаточно денег!";
        }
        private void DrinkOptions(Drink dr)
        {
            ZeroOptions();

            if (!dr.Sugar) trackBarSugar.Enabled = false;
            if (!dr.Strong) trackBarStrong.Enabled = false;
            if (!dr.Cream) creamCheckBox.Enabled = false;
            if (!dr.Milk) milkCheckBox.Enabled = false;
        }

        private void ZeroOptions()
        {
            trackBarSugar.Value = 0;
            trackBarStrong.Value = 0;
            creamCheckBox.Checked = false;
            milkCheckBox.Checked = false;
        }

        private void FinishWork()
        {
            ZeroOptions();

            foreach (DrinkControl drinkControl in Controls.OfType<DrinkControl>())
            {
                if (drinkControl.Tag.ToString() == "1")
                {
                    drinkControl.BackColor = Color.White;
                    drinkControl.Enabled = true;
                }
            }

            trackBarSugar.Enabled = true;
            trackBarStrong.Enabled = true;
            creamCheckBox.Enabled = true;
            milkCheckBox.Enabled = true;

            timer1.Enabled = false;

            progressBar1.Visible = false;
            progressBar1.Value = 0;
            labelDrinkReady.Text = "";

            afterChoose = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value++;
            else
            {
                labelDrinkReady.Text = "Ваш напиток готов!";
                timer1.Stop();
            }
        }
    }
}
