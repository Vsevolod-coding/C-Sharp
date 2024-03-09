// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void ReversedArray(int[] array, int index)
{
    if(index >= 0)
    {
        Console.Write($"{array[index]} ");
        ReversedArray(array, index-1);
    }
}

Console.Clear();
Console.WriteLine("Not Reversed");

int[] array = { 4, 2, 1, 0, 32, 85, 100 };
// Print нач. массив
foreach (int item in array)
{
    Console.Write(item + " ");
}

Console.WriteLine("\nReversed");

ReversedArray(array, array.Length -1);