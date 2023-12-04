// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

int[,] generationNewMatrix() {
    Random random = new Random();
    int numberOfRows = random.Next(2, 10), numberOfColumns = random.Next(2, 10);
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
Console.WriteLine("Матрица:");
printMatrix(matrix);

int rowSum, minimalRowSum = -1, indexMinimalRowSum = 0;
for (int row = 0; row < matrix.GetLength(0); row++) {
    rowSum = 0;
    for (int column = 0; column < matrix.GetLength(1); column++) {
        rowSum += matrix[row, column];
    }

    if (minimalRowSum == -1 || rowSum < minimalRowSum) {
        minimalRowSum = rowSum;
        indexMinimalRowSum = row;
    }
}

Console.WriteLine($"Строка с минимальной суммой: {indexMinimalRowSum} (сумма: {minimalRowSum})");

