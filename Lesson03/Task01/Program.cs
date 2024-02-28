/*
Задача №1
Вычислить значение функции a*b/c+d, где
a, b, c, d некоторые числа. Решение оформить в виде функции.
*/

double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}
double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);
