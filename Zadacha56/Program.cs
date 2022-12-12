// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

if (rows != columns)
{
    int[,] array = GetArray(rows, columns, 0, 10);
    PrintArray(array);
    Console.WriteLine();
    GetMinSumRow(array);
}
else
{
    Console.WriteLine("Введите количество строк отличное от количества столбцов");
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetMinSumRow(int[,] inArray)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;

    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        minRow += inArray[0, i];
    }
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
            sumRow += inArray[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1} строка");
}

