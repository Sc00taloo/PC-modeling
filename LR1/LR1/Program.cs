using System.Runtime.InteropServices;

int[] x = { 5, 15, 25, 35, 45, 55 };
double[] y = { 2.2f, 2.4f, 2.6f, 2.7f, 2.8f, 2.9f };
int n = 6;

Console.WriteLine("Линейная функция");
double xi = 0.0f;
double yi = 0.0f;
double x2 = 0.0f;
double xy = 0.0f;
for (int i = 0; i < n; i++)
{
    xi += x[i];
    yi += y[i];
    x2 += Math.Pow(x[i],2);
    xy += x[i] * y[i];
}
//Console.WriteLine(xi);
//Console.WriteLine(yi);
//Console.WriteLine(x2);
//Console.WriteLine(xy);

double Determinant = Math.Round((x2 * n) - (xi * xi), 4);
double Determinant1 = Math.Round((xy * n) - (xi * yi), 4);
double Determinant2 = Math.Round((x2 * yi) - (xy * xi), 4);
//Console.WriteLine(Determinant);
//Console.WriteLine(Determinant1);
//Console.WriteLine(Determinant2);

double a = Math.Round(Determinant1 / Determinant, 2);
double b = Math.Round(Determinant2 / Determinant, 2);
//Console.WriteLine(a);
//Console.WriteLine(b);
Console.WriteLine("Завершено");
Console.WriteLine("Степенная функция");

double[] xln = new double[n];
double[] yln = new double[n];
for (int i = 0; i < n; ++i)
{
    xln[i] = Math.Log(x[i]);
    yln[i] = Math.Log(y[i]);
}
//for (int i = 0; i < n; ++i)
//{
//    Console.Write(xln[i]);
//}
//for (int i = 0; i < n; ++i)
//{
//    Console.Write(yln[i]);
//}

double xlni = 0.0f;
double ylni = 0.0f;
double xln2 = 0.0f;
double xlnyln = 0.0f;
for (int i = 0; i < n; i++)
{
    xlni += xln[i];
    ylni += yln[i];
    xln2 += Math.Pow(xln[i], 2);
    xlnyln += xln[i] * yln[i];
}
Determinant = Math.Round((xln2 * n) - (xlni * xlni), 4);
Determinant1 = Math.Round((xlnyln * n) - (xlni * ylni), 4);
Determinant2 = Math.Round((xln2 * ylni) - (xlnyln * xlni), 4);
//Console.WriteLine(Determinant);
//Console.WriteLine(Determinant1);
//Console.WriteLine(Determinant2);

double aln = Math.Round(Determinant1 / Determinant, 2);
double bln = Math.Round(Determinant2 / Determinant, 2);
double b_exp = Math.Round(Math.Exp(bln), 2);
Console.WriteLine("Завершено");
Console.WriteLine("Показательная функция");

xi = 0.0f;
ylni = 0.0f;
x2 = 0.0f;
double xiyln = 0.0f;
for (int i = 0; i < n; i++)
{
    xi += x[i];
    ylni += yln[i];
    x2 += Math.Pow(x[i], 2);
    xiyln += x[i] * yln[i];
}
Determinant = Math.Round((x2 * n) - (xi * xi), 4);
Determinant1 = Math.Round((xiyln * n) - (xi * ylni), 4);
Determinant2 = Math.Round((x2 * ylni) - (xiyln * xi), 4);
double expFunctionA = Math.Round(Determinant1 / Determinant, 2);
double expFunctionB = Math.Round(Determinant2 / Determinant, 2);
double b_expFunction = Math.Round(Math.Exp(expFunctionB), 2);
Console.WriteLine("Завершено");
Console.WriteLine("Квадратичная функция");

double x4 = 0.0f;
double x3 = 0.0f;
x2 = 0.0f;
xi = 0.0f;
double x2yi = 0.0f;
xy = 0.0f;
yi = 0.0f;
for (int i = 0; i < n; ++i)
{
    x4 += Math.Pow(x[i], 4);
    x3 += Math.Pow(x[i], 3);
    x2 += Math.Pow(x[i], 2);
    xi += x[i];
    x2yi += Math.Pow(x[i], 2) * y[i];
    xy += x[i] * y[i];
    yi += y[i];
}
//Console.WriteLine(x4);
//Console.WriteLine(x3);
//Console.WriteLine(x2);
//Console.WriteLine(xi);
//Console.WriteLine(x2yi);
//Console.WriteLine(xy);
//Console.WriteLine(yi);
Determinant = Math.Round((x4 * x2 * n) + (x3 * xi * x2) + (x2 * x3 * xi) - (x2 * x2 * x2) - (x4 * xi * xi) - (x3 * x3 * n), 4);
Determinant1 = Math.Round((x2yi * x2 * n) + (x3 * xi * yi) + (x2 * xy * xi) - (x2 * x2 * yi) - (x2yi * xi * xi) - (x3 * xy * n ), 4);
Determinant2 = Math.Round((x4 * xy * n) + (x2yi * xi * x2) + (x2 * x3 * yi) - (x2 * xy * x2) - (x4 * xi * yi) - (x2yi * x3 * n), 4);
double Determinant3 = Math.Round((x4 * x2 * yi) + (x3 * xy * x2) + (x2yi * x3 * xi) - (x2yi * x2 * x2) - (x4 * xy * xi) - (x3 * x3 * yi), 4);
//Console.WriteLine(Determinant);
//Console.WriteLine(Determinant1);
//Console.WriteLine(Determinant2);
//Console.WriteLine(Determinant3);

double quadraticFunctionA = Math.Round(Determinant1 / Determinant, 2);
double quadraticFunctionB = Math.Round(Determinant2 / Determinant, 2);
double quadraticFunctionC = Math.Round(Determinant3 / Determinant, 2);
Console.WriteLine("Завершено");

Console.WriteLine("Подсчёты");
double[] linearFunction = new double[n];
double[] powerFunction = new double[n];
double[] exponentialFunction = new double[n];
double[] quadraticFunction = new double[n];

for (int i = 0; i < n; ++i)
{
    linearFunction[i] = a * x[i] + b;
    powerFunction[i] = b_exp * Math.Pow(x[i], aln);
    exponentialFunction[i] = b_expFunction * Math.Exp(expFunctionA * x[i]);
    quadraticFunction[i] = quadraticFunctionA * Math.Pow(x[i], 2) + quadraticFunctionB * x[i] + quadraticFunctionC;
}
Console.WriteLine("Завершено");
Console.WriteLine("Погрешность");
double sumLinear = 0.0f;
double sumPower = 0.0f;
double sumExponential = 0.0f;
double sumQuadratic = 0.0f;
for (int i = 0; i < n; ++i)
{
    sumLinear += Math.Round(Math.Pow(y[i] - linearFunction[i], 2), 4);
    sumPower += Math.Round(Math.Pow(y[i] - powerFunction[i], 2), 4);
    sumExponential += Math.Round(Math.Pow(y[i] - exponentialFunction[i], 2), 4);
    sumQuadratic += Math.Round(Math.Pow(y[i] - quadraticFunction[i], 2), 4);
}
Console.Write("Линейная функция ");
Console.WriteLine(sumLinear);
Console.Write("Степенная функция ");
Console.WriteLine(sumPower);
Console.Write("Показательная функция ");
Console.WriteLine(sumExponential);
Console.Write("Квадратичная функция ");
Console.WriteLine(sumQuadratic);
double[] min = { sumLinear, sumPower, sumExponential, sumQuadratic };
double minNumber = min[0];
int index = 0;
for(int i = 0; i < min.Length; ++i)
{
    if (minNumber > min[i])
    {
        minNumber = min[i];
        index = i;
    }
}
switch (index)
{
    case 0:
        Console.WriteLine("В данной задаче лучшей аппроксимирующей функцией является линейная функция");
        break;
    case 1:
        Console.WriteLine("В данной задаче лучшей аппроксимирующей функцией является степенная функция");
        break;
    case 2:
        Console.WriteLine("В данной задаче лучшей аппроксимирующей функцией является показательная функция");
        break;
    case 3:
        Console.WriteLine("В данной задаче лучшей аппроксимирующей функцией является квадратичная функция");
        break;
}

//for (int i = 0; i < n; ++i)
//{
//    Console.Write(linearFunction[i]);
//    Console.Write(" ");
//}
//Console.WriteLine();
//for (int i = 0; i < n; ++i)
//{
//    Console.Write(powerFunction[i]);
//    Console.Write(" ");
//}
//Console.WriteLine();
//for (int i = 0; i < n; ++i)
//{
//    Console.Write(exponentialFunction[i]);
//    Console.Write(" ");
//}
//Console.WriteLine();
//for (int i = 0; i < n; ++i)
//{
//    Console.Write(quadraticFunction[i]);
//    Console.Write(" ");
//}