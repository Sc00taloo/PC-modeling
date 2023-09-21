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

namespace LR2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            int R = 14;
            int N = 200;
            double[] z = new double[N * 2];
            Random rnd = new Random();
            R = R * 2;
            double mean = 0;
            double var = 0;
            for (int i = 0; i < N * 2; ++i)
            {
                z[i] = rnd.NextDouble() * R;
                mean += z[i];
            }
            R = R / 2;
            mean = mean / N;
            for (int i = 0; i < N * 2; ++i)
            {
                var += Math.Pow((z[i] - mean), 2) / 200;
            }
            double r = (double)R;
            //Console.WriteLine((4 * r) * (r / 12));

            double[] x = new double[N];
            double[] y = new double[N];
            double M = 0;
            for (int j = 0; j < N; ++j)
            {
                x[j] = z[j];
                y[j] = z[j + N];
                if (Math.Pow(x[j] - r, 2) + Math.Pow(y[j] - r, 2) < Math.Pow(r, 2))
                {
                    M += 1;
                }
                this.chart1.Series[1].Points.AddXY(x[j], y[j]);

            }
            double S = M / N * Math.Pow(2 * r, 2);
            double pi = S / Math.Pow(r, 2);
            double fi = 0;
            do
            {
                double X = r + r * Math.Cos(fi);
                double Y = r + r * Math.Sin(fi);
                this.chart1.Series[0].Points.AddXY(X, Y);
                fi += 0.1;
            } while (fi < 2 * Math.PI);

        }


    }
}
