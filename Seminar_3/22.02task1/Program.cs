// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.

int num = 100;
int [] array = new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

bool flag = false;

foreach(int item in array){
    if(item == num){
        flag = true;
    }
}

if(flag ){
    Console.Write("ДА");
}
else{
    Console.Write("Нет");
}