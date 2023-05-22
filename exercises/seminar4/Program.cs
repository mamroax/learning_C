/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

double Exponentiate(int number, int power)
{
    return Math.Pow(number, power);
}
Console.Write("Write two numbers separated by a space ");
int[] str = Console.ReadLine().Split().Select(int.Parse).ToArray();
int a = str[0];
int b = str[1];
Console.Write($"{a}, {b} -> ");
Console.Write(Exponentiate(a, b));

/*
Задача 27: Напишите программу, которая принимает
 на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int CalcSumOfDigits(int number, int sum)
{
    if (number < 10)
    {
        sum += number;
    }
    else
    {
        sum = CalcSumOfDigits(number / 10, sum) + number % 10;
    }
    return sum;
}
Console.Write("Write a number ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num} -> {CalcSumOfDigits(num, 0)}");

/*
Задача 29: Напишите программу, которая задаёт
 массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] makeArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i]);
        if (i<size-1) Console.Write(", ");
        else Console.Write(" -> ");
    }
    return newArray;
}
Console.WriteLine("write array size ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("write min element ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("write max element ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = makeArray(size, min, max);
Console.Write("[");
for (int i = 0; i < size; i++){
    Console.Write(myArray[i]);
    if (i<size-1) Console.Write(", ");
    else Console.Write("]");
}