using System;

static (float, float) matAndDis(float[] y)
{
    float sum = 0.0f;
    for (int i = 0; i < 1000; ++i)
    {
        sum += y[i];
    }
    float avg = sum / 1000;

    sum = 0.0f;
    for(int i = 0; i < 1000; ++i)
    {
        sum += (float)Math.Pow(y[i] - avg, 2);
    }
    float var = sum / 1000;
    return (avg, var);
}

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

for(int i = 0; i < N; ++i)
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
Console.WriteLine("Равномерное распределение:");
Console.WriteLine("Математическое ожидание: " + ravnoAvg);
Console.WriteLine("Дисперсия: " + ravnoVar);

Console.WriteLine("\nЭкспоненциальное распределение:");
Console.WriteLine("Математическое ожидание: " + exponAvg);
Console.WriteLine("Дисперсия: " + exponVar);

Console.WriteLine("\nНормальное распределение:");
Console.WriteLine("Математическое ожидание: " + normalAvg);
Console.WriteLine("Дисперсия: " + normalVar);