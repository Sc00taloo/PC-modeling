using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int u = 5;
            double t = 0;
            double k = 0;
            //List<double> x = new List<double>();
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            do
            {
                double test = Math.Sqrt(29 - u * Math.Pow(Math.Cos(t), 2));
                if (k < test)
                {
                    k = Math.Ceiling(test);
                }
                this.chart1.Series[0].Points.AddXY(t, test);
                t += 0.125;
                //x.Add(test);
            } while (t < 5);
            int b = (int)k;
            int a = (int)t;

            int N = 200;
            Random rnd = new Random();
            double[] x = new double[N];
            double[] y = new double[N];
            int M = 0;
            for (int i = 0; i < N; ++i)
            {
                x[i] = rnd.NextDouble() * a;
                y[i] = rnd.NextDouble() * b;
                double test = Math.Sqrt(29 - u * Math.Pow(Math.Cos(x[i]), 2));
                if (y[i] < test)
                {
                    M += 1;
                }
                this.chart1.Series[1].Points.AddXY(x[i], y[i]);
            }
        }

    }
}
