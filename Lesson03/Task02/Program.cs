/*
Задача №2
Вывод на экран квадратов чисел от 1 до N.
*/



int n = 7;
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);
int sum = GetSumOfElements(arr);
int product = GetProductOfElements(arr);
Console.WriteLine("Сумма элементов массива: " + sum);
Console.WriteLine("Произведение элементов массива: " + product);

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = i + 1;
    }
}

void PrintArray(int[] arr)
{
    Console.WriteLine("Элементы массива:");
    foreach (int element in arr)
    {
        Console.Write(element + " ");
    }
    Console.WriteLine();
}

int GetSumOfElements(int[] arr)
{
    int sum = 0;
    foreach (int element in arr)
    {
        sum++;
    }
    return sum;
}

int GetProductOfElements(int[] arr)
{
    int product = 1;
    foreach (int element in arr)
    {
        product = product * element;
    }
    return product;
}





