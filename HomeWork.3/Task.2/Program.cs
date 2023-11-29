// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

void printArray(int[] array, int size) {
    Console.Write("Массив: [ ");
    for (int index = 0; index < size; index++) {
        Console.Write($"{array[index]} ");
    }
    Console.WriteLine("]");
}

int arraySize = 10;
int[] array = new int[arraySize];
for (int index = 0; index < arraySize; index++) {
    array[index] = new Random().Next(1, 101);
}
printArray(array, arraySize);

int soughtNumbersCounter = 0; 
for (int index = 0; index < arraySize; index++) {
    if (array[index] % 2 == 0) {
        soughtNumbersCounter++;
    }
}

Console.WriteLine($"{soughtNumbersCounter} чисел в массиве чётны");
