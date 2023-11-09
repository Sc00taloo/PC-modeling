using System;

int N = 500;
float[] naladka = new float[N];
Random randObj = new Random();
for (int i = 0; i < N; i++)
{
    naladka[i] = (float)(randObj.NextDouble() * (0.5 + 0.2) - 0.2);
}