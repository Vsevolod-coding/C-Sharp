int size = 10;
int[] array = new int[size];
int i = 0;
while (i < size)
{
    Console.WriteLine("Введите элемент массива (целове число): ");
    string? input = Console.ReadLine();
    array[i] = Convert.ToInt32(input);
    i++;
}

i = 0;
Console.WriteLine("Ваш массив:");
while (i < size)
{
    Console.Write($"{array[i]}");
    if (i < array.Length - 1)
    {
        Console.Write(", ");
    }
    i++;
}
