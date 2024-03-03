/*
Задача №2
• Назовём число «интересным» если его сумма
цифр чётная
• Создать двумерный массив, состоящий из
целых чисел. Вывести на экран «интересные»
элементы массива
*/

int[,] CreateMatrix(int rowCount, int columnsCount)
{
    int[,] matrix = new int[rowCount, columnsCount];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);

foreach (int e in matrix)
{
    if (IsInteresting(e))
    {
        Console.WriteLine(e);
    }
}

bool IsInteresting(int value)
{
    int SumOfDigits = GetSumOfDigits(value);
    return SumOfDigits % 2 == 0;
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}

