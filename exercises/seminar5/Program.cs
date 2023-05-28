/*
Задача 34: Задайте массив заполненный
случайными положительными трёхзначными числами.
Напишите программу, которая покажет
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

// void ShowEven(int size)
// {
//     int[] myArray = new int[size];
//     int countEven = 0;
//     Console.Write("[");
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(100, 999);
//         Console.Write(myArray[i]);
//         if (i < size - 1)
//         {
//             Console.Write(", ");
//         }
//         if (myArray[i] % 2 == 0)
//         {
//             countEven++;
//         }
//     }
//     Console.Write("] -> " + countEven);
// }

// Console.Write("input an array size ");
// int size = Int32.Parse(Console.ReadLine());
// ShowEven(size);

/*
Задача 36: Задайте одномерный массив,
заполненный случайными числами. Найдите
сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

// void ShowOddSum(int size)
// {
//     int[] myArray = new int[size];
//     int countSum = 0;
//     Console.Write("[");
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(-100, 100);
//         Console.Write(myArray[i]);
//         if (i < size - 1)
//         {
//             Console.Write(", ");
//         }
//         if (i % 2 == 1)
//         {
//             countSum += myArray[i];
//         }
//     }
//     Console.Write("] -> " + countSum);
// }

// Console.Write("input an array size ");
// int size = Int32.Parse(Console.ReadLine());
// ShowOddSum(size);

/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным
 и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void ShowMaxMinDiff(int size)
{
    double[] myArray = new double[size];
    myArray[0] = Math.Round(new Random().NextDouble() * 100, 2);
    double minNum = myArray[0];
    double maxNum = myArray[0];
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        if (i > 0)
        {
            myArray[i] = Math.Round(new Random().NextDouble() * 100, 2);
        }
        Console.Write(myArray[i]);
        if (i < size - 1)
        {
            Console.Write(", ");
        }
        if (maxNum < myArray[i])
        {
            maxNum = myArray[i];
        }
        if (minNum > myArray[i])
        {
            minNum = myArray[i];
        }
    }
    if (size == 1)
    {
        Console.Write("] -> " + (minNum));
    }
    else
    {
        Console.Write("] -> " + (minNum + maxNum));
    }
}

Console.Write("input an array size ");
int size = Int32.Parse(Console.ReadLine());
ShowMaxMinDiff(size);