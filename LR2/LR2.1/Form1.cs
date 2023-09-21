using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            this.chart1.Series[2].Points.Clear();
            //double[] fx1 = new double[27];
            //double[] fx2 = new double[27];
            //double[] x = new double[27];
            int n = 14;
            double t = 0;
            int b = 0;
            do
            {
                double test = (10 * t) / n;
                double test2 = 10 * ((t - 20) / (n - 20)) + 20;
                if (b < test2)
                {
                    b = (int)test2;
                }
                this.chart1.Series[0].Points.AddXY(t, test);
                this.chart1.Series[1].Points.AddXY(t, test2);
                t += 0.5;

            } while (t < 23);

            int a = (int)t;
            int N = 200;
            double[] x = new double[N];
            double[] y = new double[N];
            int M = 0;
            Random rnd = new Random();
            for(int i = 0; i < N; ++i)
            {
                x[i] = rnd.NextDouble() * a;
                y[i] = rnd.NextDouble() * b;
                double test = (10 * x[i]) / n;
                double test2 = 10 * ((x[i] - 20) / (n - 20)) + 20;
                if (test < y[i] & y[i] < test2)
                {
                    M += 1;
                }
                this.chart1.Series[2].Points.AddXY(x[i], y[i]);
            }



            //for (int i = 0; i < 27; ++i)
            //{
            //    x[i] = i;
            //    fx1[i] = (10 * i) / n;
            //    fx2[i] = 10 * ((i - 20) / (n - 20)) + 20;
            //}
            //this.chart1.Series[0].Points.Clear();
            //this.chart1.Series[1].Points.Clear();
            //for (int i = 0; i < 27; ++i)
            //{
            //    this.chart1.Series[0].Points.AddXY(x[i], fx1[i]);
            //    this.chart1.Series[1].Points.AddXY(x[i], fx2[i]);
            //}
            //int u = 5;
            //double t = 0;
            //List<double> x = new List<double>();
            //this.chart1.Series[0].Points.Clear();
            //this.chart1.Series[1].Points.Clear();
            //this.chart1.Series[2].Points.Clear();
            //do
            //{
            //    double test = Math.Sqrt(29 - u * Math.Pow(Math.Cos(t), 2));
            //    this.chart1.Series[2].Points.AddXY(t, test);
            //    t += 0.125;
            //    x.Add(test);
            //} while (t < 5);
        }

    }
}
