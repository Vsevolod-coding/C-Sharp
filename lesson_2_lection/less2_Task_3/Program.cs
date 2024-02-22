int[] list = { 2, 4, 8, 5, 3, 34, 45, 21, 2, 88, 67, 36, 83, 3, 5, 34, 534, 1 };
int i = 0;
int max = list[0];

while (i < list.Length)
{
    if (list[i] > max)
    {
        max = list[i];
    }
    i++;
}
Console.WriteLine(max);

max = list[0];

for (int j = 0; j < list.Length; j++)
{
    if (list[j] > max)
    {
        max = list[j];
    }
}
Console.WriteLine(max);

max = list[0];
foreach(int e in list){
    if(e > max){
        max = e;
    }
}
Console.WriteLine(max);