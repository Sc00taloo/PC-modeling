using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LR2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            int n = 14;
            int A = 3;
            int B = 7;
            int N = 179;
            double fi = 0;
            double maxx = 0;
            double maxy = 0;
            do
            {
                double x1 = Math.Sqrt(A * Math.Pow(Math.Cos(fi), 2) + B * Math.Pow(Math.Sin(fi), 2)) * Math.Cos(fi);
                if (maxx < x1)
                {
                    maxx = x1;
                }
                double y1 = Math.Sqrt(A * Math.Pow(Math.Cos(fi), 2) + B * Math.Pow(Math.Sin(fi), 2)) * Math.Sin(fi);
                if (maxy < y1)
                {
                    maxy = y1;
                }
                this.chart1.Series[0].Points.AddXY(x1, y1);
                fi += 0.05;

            } while (fi < 2 * Math.PI);

            int a = 0;
            int b = 0;
            if (maxx > maxy)
            {
                a = (int)maxx + 1;
                b = (int)maxx + 1;
            }
            else
            {
                a = (int)maxy + 1;
                b = (int)maxy + 1;
            }

            double[] x = new double[N];
            double[] y = new double[N];
            double[] fifi = new double[N];
            double[] r = new double[N];
            int M = 0;
            Random rnd = new Random();
            for (int i = 0; i < N; ++i)
            {
                x[i] = rnd.NextDouble() * (a * 2);
                y[i] = rnd.NextDouble() * (b * 2);
                x[i] = x[i] - a;
                y[i] = y[i] - b;
                this.chart1.Series[1].Points.AddXY(x[i], y[i]);
                r[i] = Math.Sqrt(Math.Pow(x[i], 2) + Math.Pow(y[i], 2));
                if (x[i] > 0)
                {
                    fifi[i] = Math.Atan(y[i] / x[i]);
                }
                else if (x[i] < 0)
                {
                    fifi[i] = Math.PI + Math.Atan(y[i] / x[i]);
                }
                else if (x[i] == 0 & y[i] > 0)
                {
                    fifi[i] = Math.PI / 2;
                }
                else if (x[i] == 0 & y[i] < 0)
                {
                    fifi[i] = -Math.PI / 2;
                }
                else
                {
                    fifi[i] = 0;
                }
                if (r[i] < fifi[i])
                {
                    M += 1;
                }
            }
        }

    }
}
