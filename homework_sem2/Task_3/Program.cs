// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

int num = 59;
int first = num / 10;
int last = num % 10;

if (10 < num && num < 99){
    if (first > last){
        Console.WriteLine(first);
    }
    else{
        Console.WriteLine(last);
    }
}