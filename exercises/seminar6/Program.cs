/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int[] CreateArrayFromConsole(int m)
{
    int number;
    int[] myArray = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i}-й элемент массива ");
        myArray[i] = Int32.Parse(Console.ReadLine());
    }
    return myArray;
}

void PrintArray(int[] array)
{
    int countPos = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i]);
        if (i < array.GetLength(0) - 1)
        {
            Console.Write(", ");
        }
        if (array[i] > 0)
        {
            countPos++;
        }
    }
    Console.Write(" -> " + countPos);
}

// Console.Write("Введите размер массива ");
// int num = Int32.Parse(Console.ReadLine());
// PrintArray(CreateArrayFromConsole(num));

/*
Задача 43: Напишите программу, которая найдёт точку
 пересечения двух прямых, заданных уравнениями
  y = k1 * x + b1, y = k2 * x + b2;
   значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void SolveEquation()
{
    Console.Write("Введите значение b1 ");
    float b1 = float.Parse(Console.ReadLine());
    Console.Write("Введите значение k1 ");
    float k1 = float.Parse(Console.ReadLine());
    Console.Write("Введите значение b2 ");
    float b2 = float.Parse(Console.ReadLine());
    Console.Write("Введите значение k2 ");
    float k2 = float.Parse(Console.ReadLine());
    float x = (b2 - b1) / (k1 - k2);
    float y = k1 * x + b1;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}

SolveEquation();