int[] arr = { 66, 2, 8, 56, 76, 978, 72, 4, 62, 914 };
int index = 0;

while (index < arr.Length){
    if (arr[index] % 2 == 0){
        Console.Write($"{arr[index]} ");
    }
    index += 1;
}