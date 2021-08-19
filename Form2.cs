using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulation_Lab16
{
    public partial class Form2 : Form
    {
        double days;
        double price;
        double total;
        double totalRubles;

        public Form2(double d, double p)
        {
            InitializeComponent();

            days = d;
            price = p;
            total = 100;
            totalRubles = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            setup();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(inputAmountToBuy.Text);
            if(amount <= 0)
            {
                MessageBox.Show("The amount must be greater than zero");
            }
            else if (amount > total)
            {
                MessageBox.Show("There is $" + total.ToString(".##") + " left");
            }
            else
            {
                total -= amount;
                totalRubles += amount * price;
                setup();
            }
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(inputAmountToSell.Text);
            if (amount <= 0)
            {
                MessageBox.Show("The amount must be greater than zero");
            }
            else if (amount > totalRubles)
            {
                MessageBox.Show("There is " + totalRubles.ToString(".##") + " rubles left");
            }
            else
            {
                totalRubles -= amount;
                total += amount / price;
                setup();
            }
        }

        public void setup()
        {
            labelTotal.Text = "Total: $" + total.ToString(".##");
            labelDays.Text = "Days: " + days.ToString("#");
            labelPrice.Text = "$1 is " + price.ToString(".##") + " rubles";
            labelTotalRubles.Text = "Total: " + totalRubles.ToString(".##") + " rubles";

            label5.Text = "You have " + totalRubles.ToString(".##") + " rubles which you can sell";
            label2.Text = "You have a $ " + total.ToString(".##") + " and with this money is possible to buy rubles at the price indicated";
        }
    }
}
