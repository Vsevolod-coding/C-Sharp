// Задача 2:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

static int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return A(m - 1, 1);
    }
    else
    {
        return A(m - 1, A(m, n - 1));
    }
}

int m = 3;
int n = 4;

int result = A(m, n);
Console.WriteLine($"Результат функции Аккермана для m={m} и n={n}: {result}");
