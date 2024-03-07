// Задача 2:
// Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string str = "HellO)_GuYS";

string newstr = str.ToLower();

Console.Write(newstr);




// XD моя попытка сделать это через цикл
// char ToLowerLetter(string str)
// {
//     string resultString = "";

//     for(int i = 0; i < str.Length; i++)
//     {
//         char newStr = str.ToLower(]);
//         resultString += str[i];
//     }

//     return resultString;
// }