// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

int num = 734657345;

string digitsString = num.ToString();
Console.WriteLine(digitsString.Length);
for (int i = 0; i < digitsString.Length; i++)
{
    Console.Write(digitsString[i]);
    if (i < digitsString.Length - 1)
    {
        Console.Write(", ");
    }
}
