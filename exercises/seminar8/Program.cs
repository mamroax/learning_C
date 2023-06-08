int[,] RowsToColumns(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        System.Console.WriteLine("Invalid input");
        return array;
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
    }
    return array;
}

int[,] Create2DArray(int rows, int colums, int minVal, int maxVal)
{
    int[,] array2d = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array2d[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return array2d;
}

void PrintArray2d(int[,] array)
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

// Console.WriteLine("input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input colums");
// int colums = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("input minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, colums, minValue, maxValue);

// PrintArray2d(myArray);
// myArray = RowsToColumns(myArray);
// PrintArray2d(myArray);

/*Задание 1. Задайте двумерный массив. Напишите программу,
 которая поменяет местами первую и последнюю строку массива.*/

int[,] SwapRows(int[,] oldArray, int indFirst, int indSecond)
{
    int sizeRow = oldArray.GetLength(1);
    int[] row = new int[sizeRow];
    for (int j = 0; j < oldArray.GetLength(0); j++)
    {
        row[j] = oldArray[indFirst, j];
        oldArray[indFirst, j] = oldArray[indSecond, j];
        oldArray[indSecond, j] = row[j];
    }
    return oldArray;
}

void Task1()
{
    Console.WriteLine("input rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input colums");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("input minValue");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input maxValue");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] myArray = Create2DArray(rows, colums, minValue, maxValue);
    PrintArray2d(myArray);
    myArray = SwapRows(myArray, 0, rows - 1);
    PrintArray2d(myArray);
}

// Task1();

/*Задание 3. Из двумерного массива целых чисел удалить строку и столбец,
 на пересечении которых расположен наименьший элемент.
то есть удалаем и строку и столбец в которой находится этот элемент*/

int[] FindMinIndex(int[,] myArray)
{
    int[] coord = new int[2];
    coord[0] = 0;
    coord[1] = 0;
    int minElem = myArray[0, 0];
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            if (minElem > myArray[i, j])
            {
                minElem = myArray[i, j];
                coord[0] = i;
                coord[1] = j;
            }
        }
    }
    return coord;
}

int[,] CreateNewArray(int[,] oldArray, int[] coord)
{
    int sizeColumns = oldArray.GetLength(0) - 1;
    int sizeRow = oldArray.GetLength(1) - 1;
    int[,] newArray = new int[sizeColumns, sizeRow];
    for (int i = 0; i < sizeColumns; i++)
    {
        for (int j = 0; j < sizeRow; j++)
        {
            if ((i < coord[0]) && (j < coord[1]))
            {
                newArray[i, j] = oldArray[i, j];
            }
            if ((i >= coord[0]) && (j >= coord[1]))
            {
                newArray[i, j] = oldArray[i + 1, j + 1];
            }
            if ((i >= coord[0]) && (j < coord[1]))
            {
                newArray[i, j] = oldArray[i + 1, j];
            }
            if ((i < coord[0]) && (j >= coord[1]))
            {
                newArray[i, j] = oldArray[i, j + 1];
            }
        }
    }
    return newArray;
}

void Task3()
{
    Console.WriteLine("input rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input colums");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input minValue");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input maxValue");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] myArray = Create2DArray(rows, colums, minValue, maxValue);
    int[] coordinates = FindMinIndex(myArray);
    PrintArray2d(myArray);
    int[,] newArray = CreateNewArray(myArray, coordinates);
    PrintArray2d(newArray);
}

// Task3();

/*
Задача 54: Задайте двумерный массив.
 Напишите программу, которая упорядочит 
 по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] Regularize(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] row = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            row[j] = array[i, j];
        }
        Array.Sort(row);
        Array.Reverse(row);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = row[j];
        }
    }
    return array;
}

void Task54()
{
    Console.WriteLine("input rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input colums");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input minValue");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input maxValue");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] myArray = Create2DArray(rows, colums, minValue, maxValue);
    PrintArray2d(myArray);
    myArray = Regularize(myArray);
    PrintArray2d(myArray);
}
// Task54();

/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и
 выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int GetMinSumRow(int[,] array)
{
    int minRowIndex = 0;
    int minSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum += array[0, j];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            minRowIndex = i;
        }
    }

    Console.WriteLine($"Минимальная сумма элементов строки {minSum}");
    return minRowIndex;
}

void Task56()
{
    Console.WriteLine("input rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input colums");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input minValue");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input maxValue");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] myArray = Create2DArray(rows, colums, minValue, maxValue);
    PrintArray2d(myArray);
    int result = GetMinSumRow(myArray);
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result} строка, считая с нуля");
}

// Task56();

/*
Задача 58: Задайте две матрицы. Напишите программу,
 которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] MultiplyMatrixes(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int res = 0;
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                res += matrix1[i, k] * matrix2[k, j];
            }
            matrix3[i, j] = res;
        }
    }
    return matrix3;
}

void Task58()
{
    Console.WriteLine("input rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input colums");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input minValue");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input maxValue");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] firstMatrix = Create2DArray(rows, colums, minValue, maxValue);
    PrintArray2d(firstMatrix);
    int[,] secondMatrix = Create2DArray(rows, colums, minValue, maxValue);
    PrintArray2d(secondMatrix);
    int[,] result = MultiplyMatrixes(firstMatrix, secondMatrix);
    PrintArray2d(result);
}

// Task58();

/*
Задача 60. ...Сформируйте трёхмерный массив из 
неповторяющихся двузначных чисел. Напишите программу,
 которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] Create3DArray(int firstDim, int secondDim, int thirdDim, int minVal, int maxVal)
{
    int[] checkArray = new int[firstDim * secondDim * thirdDim];
    int[,,] array3d = new int[firstDim, secondDim, thirdDim];
    int index = 0;
    for (int i = 0; i < firstDim; i++)
    {
        for (int j = 0; j < secondDim; j++)
        {
            for (int k = 0; k < thirdDim; k++)
            {
                int number = new Random().Next(minVal, maxVal + 1);
                while (checkArray.Contains(number))
                {
                    number = new Random().Next(minVal, maxVal + 1);
                }
                array3d[i, j, k] = number;
                checkArray[index] = number;
                index++;
            }
        }
    }
    return array3d;
}

void PrintArray3d(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{k},{j}) ");
            }
            Console.WriteLine();
        }
        // Console.WriteLine();
    }
    // Console.WriteLine();
}

void Task60()
{
    Console.WriteLine("input first dimension");
    int first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input second dimension");
    int second = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input third dimension");
    int third = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input minValue");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input maxValue");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,,] firstMatrix = Create3DArray(first, second, third, minValue, maxValue);
    PrintArray3d(firstMatrix);
}

// Task60();

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
void PrintSpire(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write(0);
            }
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CreateSpire(int size)
{
    int[,] spire = new int[size, size];
    int x = 0;
    int y = -1;
    int dRow = 0;
    int dColumn = 1;
    int i = 1;
    while (i <= size * size)
    {
        if ((0 <= x + dRow) && (x + dRow < size) && (0 <= y + dColumn) && (y + dColumn < size) && (spire[x + dRow, y + dColumn] == 0))
        {
            x += dRow;
            y += dColumn;
            spire[x, y] = i;
            i++;
        }
        else
        {
            if (dColumn == 1)
            {
                dColumn = 0;
                dRow = 1;
            }
            else if (dRow == 1)
            {
                dRow = 0;
                dColumn = -1;
            }
            else if (dColumn == -1)
            {
                dColumn = 0;
                dRow = -1;
            }
            else if (dRow == -1)
            {
                dRow = 0;
                dColumn = 1;
            }
        }
    }

    return spire;
}

void Task62()
{
    // Console.WriteLine("Input array size ");
    // int size = Convert.ToInt32(Console.ReadLine());
    int size = 4;
    int[,] matrix = CreateSpire(size);
    PrintSpire(matrix);
}

Task62();