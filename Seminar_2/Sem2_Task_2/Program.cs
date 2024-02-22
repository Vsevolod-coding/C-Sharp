// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.

int num = 123;
int num_2 = num / 10;
int second = num_2 % 10;
int last = num % 10;
int result = second;

for (int i=1; i<last; i++){
    result *= second;
}
Console.Write(result);

