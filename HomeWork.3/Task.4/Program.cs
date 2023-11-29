// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

void printArray(int[] array) {
    Console.Write("Массив: [ ");
    for (int index = 0; index < array.Length; index++) {
        Console.Write($"{array[index]} ");
    }
    Console.WriteLine("]");
}

while (true) {
    Console.Write("Введите целое число: ");
    string? stringNumber = Console.ReadLine();
    if (int.TryParse(stringNumber, out int result)) {
        int[] arrayNumber = new int[stringNumber.Length];
        for (int index = 0; index < stringNumber.Length; index++) {
            arrayNumber[index] = stringNumber[index] - 48;
        }
        printArray(arrayNumber);
        break;
    } else {
        Console.WriteLine("Это не число");
    }
}