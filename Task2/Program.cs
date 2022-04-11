// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = rnd.Next(-10, 100);
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

int Parse(string message)
{
    Console.WriteLine(message);
    string strNum = Console.ReadLine();
    int Num = int.Parse(strNum);
    return Num;
}

void Result(int arg1, int arg2, int[,] arr)
{
    if (arg1 < arr.GetLength(0) && arg2 < arr.GetLength(1))
    {
        Console.WriteLine(arr[arg1, arg2]);
    }
    else
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
}

int[,] Array = FillArray(3,4);
PrintArray(Array);

Console.WriteLine();

int n1 = Parse("Введите номер строки: ") - 1;
int n2 = Parse("Введите номер столбца: ") - 1;

Result(n1, n2, Array);
