// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] generationNewMatrix() {
    Random random = new Random();
    int numberOfRows = random.Next(1, 100), numberOfColumns = random.Next(1, 100);
    int[,] matrix = new int[numberOfRows, numberOfColumns];
    for (int row = 0; row < matrix.GetLength(0); row++) {
        for (int column = 0; column < matrix.GetLength(1); column++) {
            matrix[row, column] = random.Next(1, 100);
        }
    }
    return matrix;
}

void printMatrix(int[,] matrix) {
    Console.Write("[");
    for (int row = 0; row < matrix.GetLength(0); row++) {
        Console.Write("\n[ ");
        for (int column = 0; column < matrix.GetLength(1); column++) {
            Console.Write($"{matrix[row, column]} ");
        }
        Console.Write("]");
    }
    Console.WriteLine("\n]");
}

int[,] matrix = generationNewMatrix();
Console.WriteLine($"Двумерный массив {matrix.GetLength(0)}x{matrix.GetLength(1)}:");
printMatrix(matrix);
while(true) {
    Console.Write("Введите позицию элемента через пробел: ");
    string?[] stringPosition = Console.ReadLine().Split(" ");
    //я не придумал как добавить проверку, на то что введено менее 2ух чисел,
    //если у вас есть идеи, хотел бы обсудить
    int[] position = new int[2];
    if (int.TryParse(stringPosition[0], out int result0)) {
        position[0] = result0;
        if (int.TryParse(stringPosition[1], out int result1)) {
            position[1] = result1;
            if (position[0] < 0 || position[0] >= matrix.GetLength(0)
            || position[1] < 0 || position[1] >= matrix.GetLength(1)) {
                Console.WriteLine("Позиция не корректна: позиция за пределами массива;");
            } else {
                Console.WriteLine($"{matrix[position[0], position[1]]}");
                break;
            }
        } else {
            Console.WriteLine("Позиция не корректна: вторая координата не число;");
        }
    } else {
        Console.WriteLine("Позиция не корректна: первая координата не число;");
    }
}