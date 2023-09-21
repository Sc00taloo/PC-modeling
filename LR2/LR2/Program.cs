//int n = 14;
//double t = 0;
//int b = 0;
//do
//{
//    double test = (10 * t) / n;
//    double test2 = 10 * ((t - 20) / (n - 20)) + 20;
//    if (b < test2)
//    {
//        b = (int)test2;
//    }
//    t += 0.5;

//} while (t < 23);

//int a = (int)t;
//int N = 200;
//double[] x = new double[N];
//double[] y = new double[N];
//int M = 0;
//Random rnd = new Random();
//for (int i = 0; i < N; ++i)
//{
//    x[i] = rnd.Next(0, a);
//   // Console.WriteLine(x[i]);
//    y[i] = rnd.Next(0, b);
//    double test = (10 * x[i]) / n;
//    double test2 = 10 * ((x[i] - 20) / (n - 20)) + 20;
//    if (test < y[i] & y[i] < test2)
//    {
//        M += 1;
//    }
//}
//double S = ((double)M / (double)N) * a * b;
//double SS = 0;
//for (int i = 0; i < a; ++i)
//{
//    double test = (10 * i) / n;
//    double test2 = 10 * ((i - 20) / (n - 20)) + 20;
//    SS += test2 - test;
//}
//Console.WriteLine(S);
//Console.WriteLine(SS);



double two(int u, double x)
{
    double test = Math.Sqrt(7 - u * Math.Pow(Math.Sin(x), 2));
    return test;
}

//Console.WriteLine("Enter u: ");
//int u = Convert.ToInt32(Console.ReadLine());
int u = 3;
double t = 0;
double k = 0;
//List<double> x = new List<double>();
do
{
    double test = Math.Sqrt(7 - u * Math.Pow(Math.Sin(t), 2));
    if (k < test)
    {
        k = Math.Ceiling(test);
    }
    t += 0.125;
    //x.Add(test);
} while (t < 8);
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
    double test = Math.Sqrt(7 - u * Math.Pow(Math.Sin(i), 2));
    if (y[i] < test)
    {
        M += 1;
    }
}
double S = ((double)M / (double)N) * (double)a * (double)b;
double SS = 0;
int h = b - a / N;
double f0 = two(u, 0.0) * 0.5;
double fn = two(u, N) * 0.5;
double f1 = 0;
double f2 = 0;
for (int i = 1; i < a - 1; ++i)
{
    f1 += two(u, i);
}
for (int i = 1; i < a; ++i)
{
    f2 += two(u, (i - 1 + i) / 2);
}
SS = h / 3 * (f0 + f1 + 2 * f2 + fn);
Console.WriteLine(S);
Console.WriteLine(SS);



//int R = 14;
//int N = 200;
//double[] z = new double[N * 2];
//Random rnd = new Random();
//R = R * 2;
//double mean = 0;
//double var = 0;
//for (int i = 0; i < N * 2; ++i)
//{
//    z[i] = rnd.NextDouble() * R;
//    mean += z[i];
//}
//R = R / 2;
//mean = mean / N;
//for (int i = 0; i < N * 2; ++i)
//{
//    var += Math.Pow((z[i] - mean), 2) / 200;
//}
//double r = (double)R;
////Console.WriteLine((4 * r) * (r / 12));

//double[] x = new double[N];
//double[] y = new double[N];
//double M = 0;
//for (int j = 0; j < N; ++j)
//{
//    x[j] = z[j];
//    y[j] = z[j + N];
//    if (Math.Pow(x[j] - r, 2) + Math.Pow(y[j] - r, 2) < Math.Pow(r, 2))
//    {
//        M += 1;
//    }
//}
//double S = M / N * Math.Pow(2 * r, 2);
//double pi = S / Math.Pow(r, 2);
//double fi = 0;
//double maxy = 0;
//double maxx = 0;
//do
//{
//    double X = r + r * Math.Cos(fi);
//    if (maxx < X)
//    {
//        maxx = X;
//    }
//    double Y = r + r * Math.Sin(fi);
//    if (maxy < Y)
//    {
//        maxy = Y;
//    }
//    fi += 0.1;
//} while (fi < 2 * Math.PI);
////Console.WriteLine(maxx);
////Console.WriteLine(maxy);



//int n = 14;
//int A = 3;
//int B = 7;
//int N = 179;
//double maxx = 0;
//double maxy = 0;

//double fi = 0;
//do
//{
//    double x1 = Math.Sqrt(A * Math.Pow(Math.Cos(fi), 2) + B * Math.Pow(Math.Sin(fi), 2)) * Math.Cos(fi);
//    if (maxx < x1)
//    {
//        maxx = x1;
//    }
//    double y1 = Math.Sqrt(A * Math.Pow(Math.Cos(fi), 2) + B * Math.Pow(Math.Sin(fi), 2)) * Math.Sin(fi);
//    if (maxy < y1)
//    {
//        maxy = y1;
//    }
//    fi += 0.05;

//} while (fi < 2 * Math.PI);

//int a = 0;
//int b = 0;
//if (maxx > maxy)
//{
//    a = (int)maxx + 1;
//    b = (int)maxx + 1;
//} 
//else
//{
//    a = (int)maxy + 1;
//    b = (int)maxy + 1;
//}

//double[] x = new double[N];
//double[] y = new double[N];
//double[] fifi = new double[N];
//double[] r = new double[N];
//double M = 0;
//Random rnd = new Random();

//for (int i = 0; i < N; ++i)
//{
//    x[i] = rnd.NextDouble() * (a * 2);
//    y[i] = rnd.NextDouble() * (b * 2);
//    x[i] = x[i] - a;
//    y[i] = y[i] - b;
//    r[i] = Math.Sqrt(Math.Pow(x[i], 2) + Math.Pow(y[i], 2));
//    if (x[i] > 0)
//    {
//        fifi[i] = Math.Atan(y[i] / x[i]);
//    }
//    else if (x[i] < 0)
//    {
//        fifi[i] = Math.PI + Math.Atan(y[i] / x[i]);
//    }
//    else if (x[i] == 0 & y[i] > 0)
//    {
//        fifi[i] = Math.PI / 2;
//    }
//    else if (x[i] == 0 & y[i] < 0)
//    {
//        fifi[i] = -Math.PI / 2;
//    }
//    else
//    {
//        fifi[i] = 0;
//    }
//    if (r[i] < fifi[i])
//    {
//        M += 1;
//    }
//}

//double S = M / N * (a * b * 4);
//double ss = Math.PI / 2 * (A + B);
//double s = 0;
//fi = 0;
//do
//{
//    s += Math.Pow(Math.Sqrt(A * Math.Pow(Math.Cos(fi), 2) + B * Math.Pow(Math.Sin(fi), 2)), 2) * 0.5;
//    fi += 1.01;
//} while (fi <= 2 * Math.PI);
//Console.WriteLine(S);
//Console.WriteLine(ss);
//Console.WriteLine(s);
