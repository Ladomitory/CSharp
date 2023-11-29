// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

void printArray(double[] array, int size) {
    Console.Write("Массив: [");
    for (int index = 0; index < size; index++) {
        Console.Write($"{array[index]} ");
    }
    Console.WriteLine("]");
}

while(true) {
    Console.Write("Введите размер массива: ");
    string? stringArraySize = Console.ReadLine();
    if (int.TryParse(stringArraySize, out int parseResult)) {
        int arraySize = parseResult;
        double[] array = new double[arraySize];
        for (int index = 0; index < arraySize; index++) {
            array[index] = new Random().NextDouble();
        }
        printArray(array, arraySize);

        double minimalInArray = array[0], maximalInArray = array[0];
        for (int index = 0; index < arraySize; index++) {
            if (array[index] > maximalInArray) {
                maximalInArray = array[index];
            } else if (array[index] < minimalInArray) {
                minimalInArray = array[index];
            }
        }

        Console.WriteLine($"Разница между минимальным и максимальным числом в масиве = {maximalInArray - minimalInArray}");
        break;
    } else {
        Console.WriteLine("Не корректный формат размера массива");
    }
}