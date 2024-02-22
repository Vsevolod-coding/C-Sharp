// Задача 4**(не обязательно): Дано натуральное
// число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.

int Num = 43248;

int numDigits = 0;
int tempNumber = Num;

while (tempNumber > 0){
    tempNumber /= 10;
    numDigits++;
}

int[] digits = new int[numDigits];

tempNumber = Num;
for (int i = numDigits - 1; i >= 0; i--){
    digits[i] = tempNumber % 10; // Получение последней цифры числа
    tempNumber /= 10; // Удаление последней цифры числа
}

// Вывод массива
Console.Write($"Массив цифр числа {Num}: [ ");
foreach (int digit in digits){
    Console.Write(digit + " ");
}
Console.Write("]");
