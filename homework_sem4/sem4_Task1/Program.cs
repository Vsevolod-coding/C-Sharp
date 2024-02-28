// Задача 1
// Напишите программу, которая бесконечно запрашивает
// целые числа с консоли. Программа завершается при вводе символа ‘q’
// или при вводе числа, сумма цифр которого чётная.

Console.Clear();
while (true)
{
    Console.Write("Введите число: ");
    string input = Console.ReadLine()!;

    if (input.ToLower() == "q")
    {
        Console.WriteLine("Программа завершена.");
        break;
    }

    if(IsSumOfDigitsEven(input)){
        Console.WriteLine("Сумма цифр числа четная. Программа завершена.");
        break;
    }

    bool IsSumOfDigitsEven(string sum)
    {
        int converted_num = Convert.ToInt32(sum);
        int sum_digits = 0;
        while (converted_num > 0)
        {

            sum_digits = sum_digits + converted_num % 10;
            converted_num /= 10;
        }
            
        return sum_digits % 2 == 0;
    }
};



