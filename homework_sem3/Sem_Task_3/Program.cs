// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива. 

double [] array = {1.273, 8.2345, 2.98, 0.3143, 1.34, 5.55};
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++){
    if (array[i] > max){
        max = array[i];
    }
    if (array[i] < min){
        min = array[i];
    }
}
Console.WriteLine("Min = " + min + " Max = " + max);
Console.WriteLine("Разница между MAX и MIN элементов массива = " + (max - min));