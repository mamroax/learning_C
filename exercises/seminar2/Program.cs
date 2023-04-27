/*
Напишите программу, которая принимает на вход
число и проверяет, кратно ли оно одновременно 7 и 23.
14  ->  нет
46  ->  нет
161 ->  да
*/
bool IsMultiple(int number)
{
    return ((number%(7*23)) == 0);
}
// Console.Write("Write a number ");
// int num = Int32.Parse(Console.ReadLine());
// if (IsMultiple(num)) Console.Write($"{num} -> да");
// else Console.Write($"{num} -> нет");

/*
Напишите программу, которая принимает на
вход два числа и проверяет, является ли
одно число квадратом другого.
*/
void IsSquare(int a, int b)
{
    if (b*b == a) Console.Write($"number {a} is square of number {b}");
    else if (a*a == b) Console.Write($"number {b} is square of number {a}");
    else Console.Write($"number {b} is not square of number {a} and number {a} is not square of number {b}");
}

// Console.Write("Write first number ");
// int a = Int32.Parse(Console.ReadLine());
// Console.Write("Write second number ");
// int b = Int32.Parse(Console.ReadLine());
// IsSquare(a,b);

/*
Задача 10: Напишите программу, которая принимает
 на вход трёхзначное число и на выходе показывает
 вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
void ShowThirdNum(int number)
{
    int result = (number % 100) / 10;
    Console.Write($"{number} -> {result}");
}
// Console.Write("Введите число ");
// int num = Int32.Parse(Console.ReadLine());
// ShowThirdNum(num);

/*
Задача 13: Напишите программу,
которая выводит третью цифру
заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

void ShowThirdNumExam(int number)
{
    if (number / 100 == 0) Console.Write($"{number} -> третьей цифры нет");
    else Console.Write($"{number} -> {(number % 100) / 10}");
}
// Console.Write("Введите число ");
// int num = Int32.Parse(Console.ReadLine());
// ShowThirdNumExam(num);

/*
Задача 15: Напишите программу,
которая принимает на вход цифру,
обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
bool IsDayOff(int number)
{
    return (number == 6 || number == 7);
}
Console.Write("Введите число ");
int num = Int32.Parse(Console.ReadLine());
if (IsDayOff(num)) Console.Write($"{num} -> да");
else Console.Write($"{num} -> нет");