// Задача 1: Задайте двумерный массив символов
// (тип char [,]). Создать строку из символов этого массива.

char[,] charArray = new char[,]
{
    {'a','b','c'},
    {'d','e','f'},
    {'g','h','j'}
};

string resultString = GetStringFromCharArray(charArray);
Console.Write(resultString);


string GetStringFromCharArray(char[,] charArray)
{
    // Получение размерности массива
    int rows = charArray.GetLength(0);
    int cols = charArray.GetLength(1);

    // Создание пустой строки
    string resultString = "";

    // Обход элементов массива и добавление их к строке
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            resultString += charArray[i, j];
        }
    }
    return resultString;
}





// Обычный массив char и вывод содержимого на экран
// int ArraySize = 10;
// Random random = new Random();
// char[] charArray = new char[ArraySize];

// for(int i = 0; i < ArraySize; i++)
// {
//     char RandomChar = (Char)random.Next(32,127);
//     charArray[i] = RandomChar;
// }

// Console.WriteLine("Сгенерированный массив символов:");
// foreach(char c in charArray)
// {
//     Console.Write(c + " ");
// }

