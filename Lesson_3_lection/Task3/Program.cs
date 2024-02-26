void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] array = [0, 0, 0, 2, 234, 534, 123, 8273645, 2345235, 234, 1111];

ZeroEvenElements(array);
PrintArray(array);