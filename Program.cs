// Задача 1: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.
// Пример:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// Пример:
// m = 2, n = 3 -> A(m,n) = 29

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.
// Пример:
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

void ShowNumbersFromMtoN(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m} ");
        return;
    }
    Console.Write($"{m}, ");
    if (m > n)
    {
        ShowNumbersFromMtoN(m - 1, n);;
    }
    else
    {
        ShowNumbersFromMtoN(m + 1, n);
    }
}

int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
    else
    {
        return n + 1;
    }
}

void ShowReversArray(int[] array, int endIndexArray)
{
    if (endIndexArray < 0)
    {
        return;
    }
    Console.Write($"{array[endIndexArray]} ");
    ShowReversArray(array, endIndexArray - 1);
}

int m = 1;
int n = 4;
Console.Clear();

Console.Write("Задача 1: ");
ShowNumbersFromMtoN(m, n);
Console.WriteLine();
Console.Write("Задача 2: ");
Console.Write(Ackerman(m, n));
Console.WriteLine();
Console.Write("Задача 3: ");
int[] array = {1, 2, 5, 0, 10, 34};
int endIndexArray = array.Length - 1;
ShowReversArray(array, endIndexArray);