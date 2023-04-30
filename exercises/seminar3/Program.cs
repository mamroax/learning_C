/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// bool IsPalindrome(int number)
// {
//     int a = number / 10000;
//     int b = (number % 10000) / 1000;
//     int c = (number % 100) / 10;
//     int d = number % 10;
//     return ((a == d) && (b == c));
// }

// bool IsValid(int number)
// {
//     return (((number < 100000) && (number > 9999)) || ((number < -9999) && (number > -100000)));
// }

// Console.Write("Write a number ");
// int num = Int32.Parse(Console.ReadLine());
// if (IsValid(num) && IsPalindrome(num)) Console.Write($"{num} -> да");
// else Console.Write($"{num} -> нет");

/*
Задача 21
Напишите программу, которая принимает на вход координаты
 двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// decimal FindDistance(float x1, float y1, float z1, float x2, float y2, float z2)
// {
//     return Math.Round((decimal)Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2)),2);
// }

// Console.Write("Enter coordinates of point A ");
// int[] str = Console.ReadLine().Split().Select(int.Parse).ToArray();
// float x1 = (float)str[0];
// float y1 = (float)str[1];
// float z1 = (float)str[2];

// Console.Write("Enter coordinates of point B ");
// int[] str1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
// float x2 = (float)str1[0];
// float y2 = (float)str1[1];
// float z2 = (float)str1[2];

// Console.Write($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}), -> {FindDistance(x1, y1, z1, x2, y2, z2)}");

/*
Задача 23
Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void PrintCubes(int number)
{
    int count = 1;
    while(count<=number)
    {
        Console.Write(Math.Pow(count,2));
        if (count < number) Console.Write(", ");
        count++;
    }
}

Console.Write("Write a number ");
int num = Int32.Parse(Console.ReadLine());
Console.Write($"{num} -> ");
PrintCubes(num);