using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Simulation_Lab16
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        const int miu = 1;
        const double k = 0.1; //0.02

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            int days = (int) inputDays.Value;
            double price = (double) inputPrice.Value;

            chart1.Series[0].Points.AddXY(0, price);

            for (int i = 1; i <= days; i++)
            {
                //price = price * (1 + k * (random.NextDouble() - 0.5));
                // e^((miu - (price*price/2)) * k + price * random)

                // W(ti+1) I am not exactly sure how to calculate
                // Put it like W(t) + SQRT(dt) * rand
                double w = miu + Math.Sqrt(k) * (random.NextDouble() - 0.5);
                price = Math.Exp((miu - (price*price/2)) * k + (price * w));
                chart1.Series[0].Points.AddXY(i, price);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            DataPoint p = new DataPoint();
            ToolTip toolTip = new ToolTip();
            MouseEventArgs me = (MouseEventArgs)e;
            
            var r = chart1.HitTest(me.X, me.Y);
            if (r.ChartElementType == ChartElementType.DataPoint)
            {
                p = (DataPoint) r.Object;
                int index = r.PointIndex;

                toolTip.SetToolTip(chart1, "After " + p.XValue + " Days\nPrice: " + p.YValues[0].ToString("#.##"));
            }

            Form2 popup = new Form2(p.XValue, p.YValues[0]);
            popup.Show(this);
        }
    }
}
