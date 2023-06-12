/*Задача 3. Задайте значения M и N.
 Напишите программу, которая выведет
  все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"*/

void GetNext(int m, int n)
{
    if (m < n)
    {
        Console.Write(m + " ");
        GetNext(m + 1, n);
    }
    else if (n < m)
    {
        Console.Write(n + " ");
        GetNext(n + 1, m);
    }
    else
    {
        Console.Write(n);
    }
}
// GetNext(5, 1);

/*
Задача 4.Напишите программу, которая на вход принимает
 два числа A и B, и возводит число А в целую степень B с помощью рекурсии.*/

int PrintNum(int a, int b)
{
    if (b > 0)
    {
        return PrintNum(a, b - 1) * a;
    }
    else return 1;
}
// Console.Write(PrintNum(2, 2));

/*
Задача 64: Задайте значение N. Напишите программу,
 которая выведет все натуральные числа
  в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int PrintNext(int n)
{
    if (n > 1)
    {
        Console.Write(n);
        if (n != 1)
        {
            Console.Write(", ");
        }
        PrintNext(n - 1);
    }
    return 1;
}

void Task64()
{
    Console.Write("Введите число N ");
    int n = Int32.Parse(Console.ReadLine());
    Console.Write($"N = {n} -> \"");
    Console.Write(PrintNext(n));
    Console.Write("\"");
}
// Task64();

/*
Задача 66: Задайте значения M и N. Напишите программу,
 которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetSum(int m, int n)
{
    if (m < n)
    {
        return GetSum(m + 1, n) + m;
    }
    else return n;
}

void Task66()
{
    Console.Write("Введите натуральное число M ");
    int m = Int32.Parse(Console.ReadLine());
    Console.Write("Введите натуральное число N ");
    int n = Int32.Parse(Console.ReadLine());
    Console.Write($"M = {m}; N = {n} -> ");
    Console.Write(GetSum(m, n));
}
// Task66();

/*
Задача 68: Напишите программу 
вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int Ackermann(int n, int m)
{
    while (n != 0)
    {
        if (m == 0)
        {
            m = 1;
        }
        else
        {
            m = Ackermann(n, m - 1);
        }
        n = n - 1;
    }
    return (m + 1);
}

void Task68()
{
    Console.Write("Введите натуральное число M ");
    int m = Int32.Parse(Console.ReadLine());
    Console.Write("Введите натуральное число N ");
    int n = Int32.Parse(Console.ReadLine());
    Console.Write($"m = {m}, n = {n} -> A({m},{n}) = ");
    Console.Write(Ackermann(m,n));
}
Task68();