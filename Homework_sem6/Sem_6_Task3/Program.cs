// Задача 3:
// Задайте произвольную строку.
// Выясните, является ли она палиндромом.
using System.Diagnostics;

// Console.WriteLine("Введите слово: "); // Добавляем если вводим с консоли

// string word = Console.ReadLine()!; // Этот код только если вводим англ слова
string word = "abcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcbaabcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcbaabcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcbaabcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcbaabcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcbaabcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcbaabcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcbaabcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcbaabcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcbaabcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgfedcba"; // Этот код для русской и англ. раскладки

int first = 0;
int last = word.Length - 1;
Stopwatch sw = new Stopwatch();
sw.Start();
for(int i = 0; i < word.Length / 2; i++)
{
    if(word[first] != word[last])
        {
            Console.Write($"Слово {word} не является палиндромом. {sw.ElapsedMilliseconds}ms");
            return;
        }
    first++;
    last--;
}
sw.Stop();
Console.Write($"Слово {word} является палиндромом. {sw.ElapsedMilliseconds}ms");
