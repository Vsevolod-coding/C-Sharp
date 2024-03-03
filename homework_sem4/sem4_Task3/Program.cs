// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

int[] NumArray = { 1, 2, 3, 4, 5, 6, 87, 8, 9, 97, 6777, 95754, 6435, 3543, 12, 46, 7, 67, 8, 8723132, 36 };

int first = 0;
int last = NumArray.Length - 1;

while (first < last)
{
    int temp = NumArray[first];
    NumArray[first] = NumArray[last];
    NumArray[last] = temp;
    first++;
    last--;
}

foreach (int i in NumArray)
{
    Console.Write(i + " ");
}



// length = len(my_list)
// first = 0
// last = length - 1

// while first < last:
//     my_list[first], my_list[last] = my_list[last], my_list[first]
//     first += 1
//     last -= 1

// print(my_list)