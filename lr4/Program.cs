using System;
using System.Runtime.CompilerServices;

static (float, float) matAndDis(float[] y, int n)
{
    float sum = 0.0f;
    for (int i = 0; i < n; ++i)
    {
        sum += y[i];
    }
    float avg = sum / n;

    sum = 0.0f;
    for(int i = 0; i < n; ++i)
    {
        sum += (float)Math.Pow(y[i] - avg, 2);
    }
    float var = sum / n;
    return (avg, var);
}

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

Console.WriteLine("Base: ");
Console.WriteLine("Expected value: " + avg);
Console.WriteLine("Dispersion: " + var);

Console.WriteLine("\nUniform distribution N = 1000, 10, 20, 50, 100:");
Console.WriteLine("Expected value N: " + ravnoAvg);
Console.WriteLine("Dispersion N: " + ravnoVar);
Console.WriteLine("Expected value N1: " + ravnoAvg1);
Console.WriteLine("Dispersion N1: " + ravnoVar1);
Console.WriteLine("Expected value N2: " + ravnoAvg2);
Console.WriteLine("Dispersion N2: " + ravnoVar2);
Console.WriteLine("Expected value N3: " + ravnoAvg3);
Console.WriteLine("Dispersion N3: " + ravnoVar3);
Console.WriteLine("Expected value N4: " + ravnoAvg4);
Console.WriteLine("Dispersion N4: " + ravnoVar4);

Console.WriteLine("\nExponential distribution N = 1000, 10, 20, 50, 100:");
Console.WriteLine("Expected value N: " + expAvg);
Console.WriteLine("Dispersion N: " + expVar);
Console.WriteLine("Expected value N1: " + expAvg1);
Console.WriteLine("Dispersion N1: " + expVar1);
Console.WriteLine("Expected value N2: " + expAvg2);
Console.WriteLine("Dispersion N2: " + expVar2);
Console.WriteLine("Expected value N3: " + expAvg3);
Console.WriteLine("Dispersion N3: " + expVar3);
Console.WriteLine("Expected value N4: " + expAvg4);
Console.WriteLine("Dispersion N4: " + expVar4);

Console.WriteLine("\nNormal distribution N = 1000, 10, 20, 50, 100:");
Console.WriteLine("Expected value N: " + normAvg);
Console.WriteLine("Dispersion N: " + normVar);
Console.WriteLine("Expected value N1: " + normAvg1);
Console.WriteLine("Dispersion N1: " + normVar1);
Console.WriteLine("Expected value N2: " + normAvg2);
Console.WriteLine("Dispersion N2: " + normVar2);
Console.WriteLine("Expected value N3: " + normAvg3);
Console.WriteLine("Dispersion N3: " + normVar3);
Console.WriteLine("Expected value N4: " + normAvg4);
Console.WriteLine("Dispersion N4: " + normVar4);