// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = rnd.Next(-10, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write($"{array[i, j]}\t");
        }
    Console.WriteLine();
    }
}

void Result(int[,] arr)
{
    double DoubRes = 0;
    for (int j = 0; j < arr.GetLength(1) - 1; j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            DoubRes = DoubRes + arr[i,j];
        }
        DoubRes = DoubRes / arr.GetLength(0);
        Console.Write($"{DoubRes:0.0}; ");
        DoubRes = 0;
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        DoubRes = DoubRes + arr[i, arr.GetLength(1) - 1];
    }
    DoubRes = DoubRes / arr.GetLength(0);
    Console.Write($"{DoubRes:0.0}");
}

int[,] Array = FillArray(3,4);
PrintArray(Array);
Console.WriteLine();
Result(Array);