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

int int_num = 3;
int min = -int_num;

while(min <= int_num){
    Console.WriteLine(min+" ");
    min++;
}

// То же самое только через for

int int_num = 3;

for(int min = -int_num; min <= int_num; min++){
    Console.WriteLine(min+" ");
}
