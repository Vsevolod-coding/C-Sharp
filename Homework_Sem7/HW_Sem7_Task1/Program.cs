// Задача 1:
// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

int M = 7;
int N = 17;


void PrintNaturalNums(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m + " ");
        PrintNaturalNums(m + 1, n);
    }
}

Console.WriteLine($"Натуральные числа в промежутке от {M} до {N}:");
PrintNaturalNums(M, N);