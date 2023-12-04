// Задача 2: Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] generationNewMatrix() {
    Random random = new Random();
    int numberOfRows = random.Next(2, 100), numberOfColumns = random.Next(1, 100);
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
Console.WriteLine("Изначальная матрица:");
printMatrix(matrix);

int tempElement;

for (int column = 0; column < matrix.GetLength(1); column++) {
    tempElement = matrix[matrix.GetLength(0) - 1, column];
    matrix[matrix.GetLength(0) - 1, column] = matrix[0, column];
    matrix[0, column] = tempElement;
}

Console.WriteLine("Конечная матрица:");
printMatrix(matrix);