// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

void printArray(int[] array) {
    Console.Write("[ ");
    for (int index = 0; index < array.Length; index++) {
        Console.Write($"{array[index]} ");
    }
    Console.WriteLine("]");
}

int arraySize = 10;
int[] originalArray = new int[arraySize];
for (int index = 0; index < originalArray.Length; index++) {
    originalArray[index] = new Random().Next(100, 1000);
}
Console.Write("Исходный массив: ");
printArray(originalArray);

int[] finalArray = new int[originalArray.Length];
for (int index = 0; index < finalArray.Length; index++) {
    finalArray[index] = originalArray[(originalArray.Length - 1) - index];
}
Console.Write("Итоговый массив: ");
printArray(finalArray);