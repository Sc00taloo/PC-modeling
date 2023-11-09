using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace lr4._1
{
    public partial class Form1 : Form
    {
        static (float, float) matAndDis(float[] y, int n)
        {
            float sum = 0.0f;
            for (int i = 0; i < n; ++i)
            {
                sum += y[i];
            }
            float avg = sum / n;

            sum = 0.0f;
            for (int i = 0; i < n; ++i)
            {
                sum += (float)Math.Pow(y[i] - avg, 2);
            }
            float var = sum / n;
            return (avg, var);
        }
        public Form1()
        {
            InitializeComponent();
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();

            int N = 1000;
            int a = 929;
            int m = 911;
            int X0 = 1019;
            float[] X = new float[N + 1];
            float[] R = new float[N];
            X[0] = X0;
            float sum = 0.0f;
            for (int i = 0; i < N; ++i)
            {
                X[i + 1] = (a * X[i]) % m;
                R[i] = (float)X[i] / m;
                sum += R[i];
            }
            float avg = sum / N;

            sum = 0.0f;
            for (int i = 0; i < 1000; ++i)
            {
                sum += (float)Math.Pow(R[i] - avg, 2);
            }
            float var = sum / N;

            ///Base///

            ///ravnoRasp
            int aa = 5;
            int bb = 12;
            float[] ravnoR = new float[N];
            sum = 0;
            for (int i = 0; i < N; i++)
            {
                ravnoR[i] = (aa + (bb - aa) * R[i]);
                sum += ravnoR[i];
            }
            float ravnoAvg = sum / N;
            sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += (float)Math.Pow(ravnoR[i] - ravnoAvg, 2);
            }
            float ravnoVar = sum / N;
            (float ravnoAvg1, float ravnoVar1) = matAndDis(ravnoR, 10);
            (float ravnoAvg2, float ravnoVar2) = matAndDis(ravnoR, 20);
            (float ravnoAvg3, float ravnoVar3) = matAndDis(ravnoR, 50);
            (float ravnoAvg4, float ravnoVar4) = matAndDis(ravnoR, 100);

            ///expRasp
            int lyam = 3;
            float[] expR = new float[N];
            sum = 0;
            for (int i = 0; i < N; i++)
            {
                //Console.WriteLine(((float)-1 / (float)lyam));
                expR[i] = ((float)-1 / (float)lyam) * (float)Math.Log(R[i]);
                sum += expR[i];
            }
            float expAvg = sum / N;
            sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += (float)Math.Pow(expR[i] - expAvg, 2);
            }
            float expVar = sum / N;
            (float expAvg1, float expVar1) = matAndDis(expR, 10);
            (float expAvg2, float expVar2) = matAndDis(expR, 20);
            (float expAvg3, float expVar3) = matAndDis(expR, 50);
            (float expAvg4, float expVar4) = matAndDis(expR, 100);

            ///noramlRasp
            float[] normR = new float[N];
            sum = 0;
            int multa = 2;
            int sigma = 2;
            float u1 = R[0];
            float u2 = R[1];
            float z = (float)(Math.Cos(2 * Math.PI * u1) * Math.Sqrt(-2 * Math.Log(u2)));
            normR[0] = multa + sigma * z;
            sum += normR[0];
            u1 = u2;

            for (int i = 2; i < N; i++)
            {
                u2 = R[i];
                z = (float)(Math.Cos(2 * Math.PI * u1) * Math.Sqrt(-2 * Math.Log(u2)));
                normR[i] = multa + sigma * z;
                sum += normR[i];
                u1 = u2;
            }
            u1 = R[N - 2];
            u2 = R[N - 1];
            float z1 = (float)(Math.Cos(2 * Math.PI * u1) * Math.Sqrt(-2 * Math.Log(u2)));
            normR[N - 1] = (multa + sigma * z1);
            sum += normR[N - 1];
            float normAvg = sum / N;
            sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += (float)Math.Pow(normR[i] - normAvg, 2);
            }
            float normVar = sum / N;
            (float normAvg1, float normVar1) = matAndDis(normR, 10);
            (float normAvg2, float normVar2) = matAndDis(normR, 20);
            (float normAvg3, float normVar3) = matAndDis(normR, 50);
            (float normAvg4, float normVar4) = matAndDis(normR, 100);


            int K = (int)Math.Round(1 + 3.2 * Math.Log10(N));
            float xxmax = bb;
            float xxmin = aa;
            float delta_x = (xxmax - xxmin) / (float)K;
            int[] list = new int[K];
            for (int i = 0; i < K; i++)
            {
                list[i] = 0;
            }
            float[] values_x = new float[K];
            for (int i = 0; i < K; i++)
            {
                values_x[i] = (float)(xxmin + i * delta_x + (0.5 * ((float)(xxmax - xxmin) / (float)K)));
            }
            for (int i = 0; i < N; i++)
            {
                double ppp = ravnoR[i];
                for (int j = 0; j < K; j++)
                {
                    if ((ppp >= xxmin + j * delta_x) && (ppp <= xxmin + (j + 1) * delta_x))
                    {
                        list[j] = list[j] + 1;
                        break;
                    }
                }
            }
            float[] values = new float[K];
            for (int i = 0; i < K; i++)
            {
                values[i] = (float)list[i] / (float)N;
            }
            float[] xx = new float[K];
            float[] yy = new float[K];
            float test = (float)1 / (float)(bb - aa);
            for (int i = 0; i < K; i++)
            {
                if (test + i + aa > bb)
                {
                    xx[i] = bb;
                }
                else
                {
                    xx[i] = test + i + aa;
                }
                yy[i] = (float)1 / (float)(bb - aa);
            }
            for (int i = 0; i < K; ++i)
            {
                this.chart1.Series[0].Points.AddXY(values_x[i], values[i]);
                this.chart1.Series[1].Points.AddXY(xx[i], yy[i]);
            }
            for (int i = 1; i < K; i++)
            {
                list[i] += list[i - 1];
            }

            List<float> xxx = new List<float>();
            List<float> yyy = new List<float>();
            xxx.Add(xxmin);
            yyy.Add(0);
            xxx.Add((float)(xxmin + 1 * delta_x + (0.5 * ((float)(xxmax - xxmin) / (float)K))));
            yyy.Add(0);
            xxx.Add((float)(xxmin + 1 * delta_x + (0.5 * ((float)(xxmax - xxmin) / (float)K))));
            yyy.Add(list[1] / (float)N);
            for (int i = 2; i < K; i++)
            {
                xxx.Add((float)(xxmin + i * delta_x + (0.5 * ((float)(xxmax - xxmin) / (float)K))));
                yyy.Add(list[i - 1] / (float)N);
                xxx.Add((float)(xxmin + i * delta_x + (0.5 * ((float)(xxmax - xxmin) / (float)K))));
                yyy.Add(list[i] / (float)N);
            }
            xxx.Add(xxmax);
            yyy.Add((float)list[K - 1] / (float)N);
            for (int i = 0; i < K; ++i)
            {
                this.chart1.Series[2].Points.AddXY(xxx[i], yyy[i]);
            }


            //int K = (int)Math.Round(1 + 3.2 * Math.Log10(N));
            //float xxmax = lyam;
            //float xxmin = 0;
            //float delta_x = (xxmax - xxmin) / (float)K;
            //int[] list = new int[K];
            //for (int i = 0; i < K; i++)
            //{
            //    list[i] = 0;
            //}
            //float[] values_x = new float[K];
            //for (int i = 0; i < K; i++)
            //{
            //    values_x[i] = (float)(xxmin + i * delta_x + (0.5 * ((float)(xxmax - xxmin) / (float)K)));
            //}
            //for (int i = 0; i < N; i++)
            //{
            //    double ppp = expR[i];
            //    for (int j = 0; j < K; j++)
            //    {
            //        if ((ppp >= xxmin + j * delta_x) && (ppp <= xxmin + (j + 1) * delta_x))
            //        {
            //            list[j] = list[j] + 1;
            //            break;
            //        }
            //    }
            //}
            //float[] values = new float[K];
            //for (int i = 0; i < K; i++)
            //{
            //    values[i] = (float)list[i] / (float)N;
            //}
            //float[] xx = new float[K];
            //float[] yy = new float[K];
            //for (int i = 0; i < K; i++)
            //{
            //    xx[i] = i;
            //    yy[i] = (float)(lyam * Math.Exp(-lyam * xx[i]));
            //}
            //for (int i = 0; i < K; ++i)
            //{
            //    this.chart1.Series[0].Points.AddXY(values_x[i], values[i]);
            //    this.chart1.Series[1].Points.AddXY(xx[i], yy[i] / 4);
            //}

            //List<float> xxx = new List<float>();
            //List<float> yyy = new List<float>();
            //xxx.Add(xxmin);
            //yyy.Add(0);
            //xxx.Add((float)(xxmin + 1 * delta_x + (0.5 * ((float)(xxmax - xxmin) / (float)K))));
            //yyy.Add(0);
            //xxx.Add((float)(xxmin + 1 * delta_x + (0.5 * ((float)(xxmax - xxmin) / (float)K))));
            //yyy.Add(list[1] / (float)N);
            //for (int i = 2; i < K; i++)
            //{
            //    xxx.Add((float)(xxmin + i * delta_x + (0.5 * ((float)(xxmax - xxmin) / (float)K))));
            //    yyy.Add(list[i - 1] / (float)N);
            //    xxx.Add((float)(xxmin + i * delta_x + (0.5 * ((float)(xxmax - xxmin) / (float)K))));
            //    yyy.Add(list[i] / (float)N);
            //}
            //xxx.Add(xxmax);
            //yyy.Add((float)list[K - 1] / (float)N);
            //for (int i = 0; i < K; ++i)
            //{
            //    this.chart1.Series[2].Points.AddXY(xxx[i], yyy[i]);
            //}


            //int K = (int)Math.Round(1 + 3.2 * Math.Log10(N));
            //float xxmax = multa;
            //float xxmin = 0;
            //float delta_x = (xxmax - xxmin) / (float)K;
            //int[] list = new int[K];
            //for (int i = 0; i < K; i++)
            //{
            //    list[i] = 0;
            //}
            //float[] values_x = new float[K];
            //for (int i = 0; i < K; i++)
            //{
            //    values_x[i] = (float)(xxmin + i * delta_x + (0.5 * ((float)(xxmax - xxmin) / (float)K)));
            //}
            //for (int i = 0; i < N; i++)
            //{
            //    double ppp = normR[i];
            //    for (int j = 0; j < K; j++)
            //    {
            //        if ((ppp >= xxmin + j * delta_x) && (ppp <= xxmin + (j + 1) * delta_x))
            //        {
            //            list[j] = list[j] + 1;
            //            break;
            //        }
            //    }
            //}
            //float[] values = new float[K];
            //for (int i = 0; i < K; i++)
            //{
            //    values[i] = (float)list[i] / (float)N;
            //}
            //float[] xx = new float[K];
            //float[] yy = new float[K];
            //for (int i = 0; i < K; i++)
            //{
            //    xx[i] = i - K / 2;
            //    yy[i] = (float)(((float)1 / (float)sigma * Math.Sqrt(2 * Math.PI)) * Math.Exp(((float)-1 / (float)2) * Math.Pow((xx[i] - multa) / sigma, 2)));
            //}
            //for (int i = 0; i < K; ++i)
            //{
            //    this.chart1.Series[0].Points.AddXY(values_x[i], values[i]);
            //    this.chart1.Series[1].Points.AddXY(xx[i] / 1.3, yy[i] / 15);
            //}

            //List<float> xxx = new List<float>();
            //List<float> yyy = new List<float>();
            //xxx.Add(xxmin);
            //yyy.Add(0);
            //xxx.Add((float)(xxmin + 1 * delta_x + (0.5 * ((float)(xxmax - xxmin) / (float)K))));
            //yyy.Add(0);
            //xxx.Add((float)(xxmin + 1 * delta_x + (0.5 * ((float)(xxmax - xxmin) / (float)K))));
            //yyy.Add(list[1] / (float)N);
            //for (int i = 2; i < K; i++)
            //{
            //    xxx.Add((float)(xxmin + i * delta_x + (0.5 * ((float)(xxmax - xxmin) / (float)K))));
            //    yyy.Add(list[i - 1] / (float)N);
            //    xxx.Add((float)(xxmin + i * delta_x + (0.5 * ((float)(xxmax - xxmin) / (float)K))));
            //    yyy.Add(list[i] / (float)N);
            //}
            //xxx.Add(xxmax);
            //yyy.Add((float)list[K - 1] / (float)N);
            //for (int i = 0; i < K; ++i)
            //{
            //    this.chart1.Series[2].Points.AddXY(xxx[i], yyy[i]);
            //}


        }
    }
}
