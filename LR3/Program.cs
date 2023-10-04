//1


//int N = 6;
//float R0 = 0.583f;
//float test = R0;
//float k = 0.0f;
//do
//{
//    test = test * 10;
//    k = k + 1;

//} while (test % 1 != 0);

//float[] R = new float[N + 1];
//float[] R_2 = new float[N];
//R[0] = R0;
//for (int i = 0; i < N; ++i)
//{
//    bool flag = true;
//    R_2[i] = R[i] * R[i];
//    double tru = R_2[i];
//    double m = Math.Round(k / 2);
//    for (int j = 0; j < k; ++j)
//    {
//        while (m != 0)
//        {
//            tru = tru * 10;
//            m -= 1;
//        }
//        while (tru > 1 && flag)
//        {
//            tru -= 1;
//        }
//        flag = false;
//        tru *= 10;

//    }
//    test = (float)tru;
//    float l = 0.0f;
//    do
//    {
//        test = test / 10;
//        l = l + 1;

//    } while (test > 1);
//    if (l != k)
//    {
//        tru -= 0.5f;
//        tru = Math.Round(tru);
//        for (int j = 0; j < k; ++j)
//        {
//            tru /= 10;
//        }
//        R[i + 1] = (float)tru;
//    }
//    else
//    {
//        tru -= 0.5f;
//        tru = Math.Round(tru);
//        while (tru > 1)
//        {
//            tru /= 10;
//        }
//        R[i + 1] = (float)tru;
//    }
//}
//for (int i = 0; i < N; ++i)
//{
//    Console.Write(R[i] + " ");
//}
//Console.WriteLine();
//for (int i = 0; i < N; ++i)
//{
//    Console.Write(R_2[i] + " ");
//}


//2


//int N = 6;
//float R0 = 0.5836f;
//float R1 = 0.2176f;
//float test = R0;
//float k = 0.0f;
//do
//{
//    test = test * 10;
//    k = k + 1;

//} while (test % 1 != 0);

//float[] R = new float[N + 3];
//float[] R_2 = new float[N + 2];
//R[0] = R0;
//R[1] = R1;
//for (int i = 0; i < N + 1; ++i)
//{
//    bool flag = true;
//    //Console.Write(R[i] + " ");
//    //Console.Write(R[i + 1] + " ");
//    R_2[i] = R[i] * R[i + 1];
//    //Console.WriteLine(R_2[i]);
//    double tru = R_2[i];
//    double m = Math.Round(k / 2);
//    for (int j = 0; j < k; ++j)
//    {
//        while (m != 0)
//        {
//            tru = tru * 10;
//            m -= 1;
//        }
//        while (tru > 1 && flag)
//        {
//            tru -= 1;
//        }
//        flag = false;
//        tru *= 10;

//    }
//    test = (float)tru;
//    float l = 0.0f;
//    do
//    {
//        test = test / 10;
//        l = l + 1;

//    } while (test > 1);
//    if (l != k)
//    {
//        tru -= 0.5f;
//        tru = Math.Round(tru);
//        for (int j = 0; j < k; ++j)
//        {
//            tru /= 10;
//        }
//        R[i + 2] = (float)tru;
//    }
//    else
//    {
//        tru -= 0.5f;
//        tru = Math.Round(tru);
//        while (tru > 1)
//        {
//            tru /= 10;
//        }
//        R[i + 2] = (float)tru;
//    }
//}
//for (int i = 0; i < N + 2; ++i)
//{
//    Console.Write(R[i] + " ");
//}
//Console.WriteLine();
//for (int i = 0; i < N + 2; ++i)
//{
//    Console.Write(R_2[i] + " ");
//}


//3


//int N = 5;
//float R0 = 0.585f;
//float g = 927;
//float test = R0;
//float k = 0.0f;
//do
//{
//    test = test * 10;
//    k = k + 1;

//} while (test % 1 != 0);

//float[] R = new float[N + 1];
//float[] Rg = new float[N];
//R[0] = R0;

//for (int i = 0; i < N; ++i)
//{
//    Rg[i] = g * R[i];
//    double tru = Rg[i];
//    while (tru > 1)
//    {
//        tru -= 1;
//    }
//    R[i + 1] = (float)Math.Round(tru, 3);
//}
//for (int i = 0; i < N + 1; ++i)
//{
//    Console.Write(R[i] + " ");
//}
//Console.WriteLine();
//for (int i = 0; i < N; ++i)
//{
//    Console.Write(Rg[i] + " ");
//}


//4


float a = 265;
float m = 129;
float x0 = 122;

float[] X = new float[7];
float[] R = new float[6];
X[0] = x0;

for (int i = 0; i < 6; ++i)
{
    X[i + 1] = (a * X[i]) % m;
    R[i] = (float)Math.Round(X[i] / m, 3);
}
for (int i = 0; i < 6; ++i)
{
    Console.Write(X[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < 6; ++i)
{
    Console.Write(R[i] + " ");
}