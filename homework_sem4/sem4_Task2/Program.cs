// Задача 2: Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
int[] array = {213, 543, 986, 742, 898, 123, 499, 998, 777, 348, 568, 522, 742, 943, 871, 880, 222, 444};

int CountEvenNums(int[] NumArr)
{
    int CountEven = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(NumArr[i] % 2 == 0)
        {
            CountEven++;
        }
    }
    return CountEven;
}

int result = CountEvenNums(array);

Console.Write($"В массиве {result} четных чисел.");