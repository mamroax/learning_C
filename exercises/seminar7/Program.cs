/*
Задача 47. Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] Create2DRandomDoubleArray(int rows, int columns, double multiplier)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * multiplier, 1);
        }
    }
    return array;
}

void Print2DDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            if (j < array.GetLength(1) - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Task49()
{
    Console.Write("Введите количество рядов массива ");
    int rows = Int16.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов массива ");
    int columns = Int16.Parse(Console.ReadLine());
    Console.WriteLine($"m = {rows}, n = {columns}.");
    Print2DDoubleArray(Create2DRandomDoubleArray(rows, columns, 10));
}

// Task49();

/*
Задача 50. Напишите программу, которая на вход
 принимает позиции элемента в двумерном массиве,
  и возвращает значение этого элемента или же указание,
   что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

double GetNumByIndex(double[,] array, int indexRow, int indexColumn)
{
    double result = -1;
    if ((indexRow <= array.GetLength(0) - 1) && (indexColumn <= array.GetLength(1) - 1))
    {
        result = array[indexRow, indexColumn];
    }
    return result;
}

void Task50()
{
    Console.Write("Введите количество рядов массива ");
    int rows = Int16.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов массива ");
    int columns = Int16.Parse(Console.ReadLine());
    Console.Write("Введите индекс ряда элемента ");
    int indexRow = Int16.Parse(Console.ReadLine());
    Console.Write("Введите индекс столбца элемента ");
    int indexColumn = Int16.Parse(Console.ReadLine());
    double[,] myArray = Create2DRandomDoubleArray(rows, columns, 10);
    Print2DDoubleArray(myArray);
    Console.Write($"Ряд {indexRow}, столбец {indexColumn} -> ");
    double number = GetNumByIndex(myArray, indexRow, indexColumn);
    if (number == -1)
    {
        Console.Write("такого числа в массиве нет");
    }
    else
    {
        Console.Write(number);
    }
}

// Task50();

/*
Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] GetColumnAverage(int[,] array)
{
    int columns = array.GetLength(1);
    double[] result = new double[columns];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int columnSum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            columnSum += array[i, j];
        }
        result[j] = Math.Round(((double)columnSum) / array.GetLength(0),2);
    }
    return result;
}

void Print1DFloatArray(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i]);
        if (i < array.GetLength(0) - 1)
        {
            Console.Write(", ");
        }
    }
}

void Task52()
{
  int[,] myArray = Create2DRandomArray(3, 4, 0, 10);
  Print2DArray(myArray);
  Console.Write($"Среднее арифметическое каждого столбца: ");
  Print1DFloatArray(GetColumnAverage(myArray));
  Console.Write(".");
}

Task52();