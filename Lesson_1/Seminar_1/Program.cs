// Задание 1

//int first = 25;
//int second = 5;

//if(second * second == first){
//    Console.WriteLine("Yes");
//}
//else{Console.WriteLine("No");
//}

// Задание 2
// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4

// int int_num = 3;
// int min = -int_num;

// while(min <= int_num){
//     Console.WriteLine(min+" ");
//     min++;
// }

// То же самое только через for

// int int_num = 3;

// for(int min = -int_num; min <= int_num; min++){
//     Console.WriteLine(min+" ");
// }

// Задание 3
// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

int number = 394;
int sim_1 = number / 100;
int sim_3 = number % 10;
int result = sim_3 + sim_1;

Console.WriteLine("Сумма 1 и 3 цифры числа = " + result);