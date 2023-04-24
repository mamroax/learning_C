/* 
Задача 2: 
Напишите программу, которая на вход принимает два числа
 и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
// Console.Write("Enter two numbers separated by a space ");
// int[] str = Console.ReadLine().Split().Select(int.Parse).ToArray();
// int a = str[0];
// int b = str[1];
// Console.Write($"a = {a}; b = {b} -> ");
// if (a > b) Console.Write($"max = {a}");
// if (a < b) Console.Write($"max = {b}");
// if (a == b) Console.Write("numbers are equal");

/* 
Задача 4: 
Напишите программу, которая принимает на вход три числа
 и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 
*/
// Console.Write("Enter three numbers separated by a space ");
// int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
// int max = numbers[0];
// for (int i = 1; i < numbers.Length; i++)
// {   
//     if (numbers[i] > max) max = numbers[i];
// }
// Console.Write($"{numbers[0]} {numbers[1]} {numbers[2]} -> {max}");

/* 
Задача 6: 
Напишите программу, которая на вход принимает число
 и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
// Console.Write("Enter one integer ");
// int number = Int32.Parse(Console.ReadLine());
// if (number % 2 == 0) 
// {
//     Console.Write($"{number} -> да");
// }
// else 
// {
//     Console.Write($"{number} -> нет");
// }

/*
Задача 8:
Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Write("Enter one integer ");
int number = Int32.Parse(Console.ReadLine());
Console.Write($"{number} -> ");
for (int i = 2; i <= number; i++)
{   
    if (i % 2 == 0)
    {
        Console.Write(i);
        if (i < number) Console.Write(", ");
    }
}