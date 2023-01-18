// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
void PrintIntegers(int N)
{
    if (N <= 1)
    {
        Console.WriteLine(N);
        return;
    }
    Console.Write($"{N}, ");
    PrintIntegers(N - 1);
}

PrintIntegers(7);