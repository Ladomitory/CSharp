// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


void printArray(int[] array) {
    Console.Write("Массив: [ ");
    for (int index = 0; index < array.Length; index++) {
        Console.Write($"{array[index]} ");
    }
    Console.WriteLine("]");
}

int arraySize = 10;
int[] array = new int[arraySize];
for (int index = 0; index < array.Length; index++) {
    array[index] = new Random().Next(100, 1000);
}
printArray(array);

int evenNumbersCounter = 0;
for (int index = 0; index < array.Length; index++) {
    if (array[index] % 2 == 0) {
        evenNumbersCounter++;
    }
}
Console.WriteLine($"Количество чётных чисел в масиве {evenNumbersCounter}");