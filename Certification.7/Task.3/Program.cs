// Задача 3: 
// Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

int[] fillArray(int[] array, int depth, Random random) {
    array[depth] = random.Next(1, 10);
    if (depth + 1 < array.Length) {
        return fillArray(array, depth + 1, random);
    } else {
        return array;
    }
}

int[] GenerateArray() {
    Random random = new Random();
    int size = random.Next(1, 10);
    int[] newArray = fillArray(new int[size], 0, random);
    return newArray;
}

void ReversePrintArray(int[] array, int depth) {
    Console.Write($"{array[array.Length - 1 - depth]} ");
    if (depth + 1 < array.Length) {
        ReversePrintArray(array, depth + 1);
    } else {
        return;
    }
}

int[] array = GenerateArray();
Console.WriteLine(array.Length);
ReversePrintArray(array, 0);