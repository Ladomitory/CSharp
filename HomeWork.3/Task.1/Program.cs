// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

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
    if (array[index] >= 20 && array[index] <= 90) {
        soughtNumbersCounter++;
    }
}

Console.WriteLine($"{soughtNumbersCounter} чисел входят в промежуток [20,90]");

