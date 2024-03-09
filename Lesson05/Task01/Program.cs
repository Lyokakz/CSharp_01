/*
Задача №1
• Вычислить факториал от натурального
числа N
*/

int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop requrson: n = {n}");
        return 1;
    }
    Console.WriteLine(n);
    int result = n * Fact(n - 1);
    Console.WriteLine($"Возврат: n = {n}, fact = {result}");

    return result;
}


Console.Write(Fact(5));

// F11 шаг с заходом
// F10 шаг с обходом
// F5 продолжить до следующей точки останова