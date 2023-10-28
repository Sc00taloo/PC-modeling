using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr4._1
{
    public partial class Form1 : Form
    {
        static (float, float) matAndDis(float[] y)
        {
            float sum = 0.0f;
            for (int i = 0; i < 1000; ++i)
            {
                sum += y[i];
            }
            float avg = sum / 1000;

            sum = 0.0f;
            for (int i = 0; i < 1000; ++i)
            {
                sum += (float)Math.Pow(y[i] - avg, 2);
            }
            float var = sum / 1000;
            return (avg, var);
        }
        public Form1()
        {
            InitializeComponent();
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();

            float a = 5;
            float b = 12;
            float lyam = 3;
            float u = 2;
            float gamma = 2;
            int N = 1000;
            Random rnd = new Random();

            float m = 3;
            float x0 = 2;

            float[] X = new float[N + 1];
            float[] R = new float[N];
            X[0] = x0;

            for (int i = 0; i < N; ++i)
            {
                X[i + 1] = (a * X[i]) % m;
                R[i] = (float)Math.Round(X[i] / m, 3);
            }

            float[] y = new float[N];
            float[] y1 = new float[N];
            float[] y2 = new float[N];
            for (int i = 0; i < N; ++i)
            {
                y[i] = a + R[i] * (b - a);
                y1[i] = (float)(-Math.Log(1 - R[i]) / lyam);
                double u1 = rnd.NextDouble();
                double u2 = rnd.NextDouble();
                float z = (float)(Math.Sqrt(-2 * Math.Log(u1)) * Math.Cos(2 * Math.PI * u2));
                y2[i] = u + gamma * z;
            }

            (float ravnoAvg, float ravnoVar) = matAndDis(y);
            (float exponAvg, float exponVar) = matAndDis(y1);
            (float normalAvg, float normalVar) = matAndDis(y2);


        }

    }
}
