// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.

int num = 457;
int first = num / 100;
int last = num % 10;

int sum = (first * 10) + last;

// Console.Write("Number without middle digit = "+first+last);
Console.Write(sum);
