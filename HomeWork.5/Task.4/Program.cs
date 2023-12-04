// Задача 4*(не обязательная):
// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца

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
    Console.WriteLine("\n]\n");
}

int[,] removeRow(int[,] matrix, int removableRow) {
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
    for (int row = 0; row < matrix.GetLength(0); row++) {
        for (int column = 0; column < matrix.GetLength(1); column++) {
            if (row < removableRow) {
                newMatrix[row, column] = matrix[row, column];
            } else if (row > removableRow) {
                newMatrix[row - 1, column] = matrix[row, column];
            }
        }
    }
    return newMatrix;
}

int[,] removeColumn(int[,] matrix, int removableColumn) {
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
    for (int row = 0; row < matrix.GetLength(0); row++) {
        for (int column = 0; column < matrix.GetLength(1); column++) {
            if (column < removableColumn) {
                newMatrix[row, column] = matrix[row, column];
            } else if (column > removableColumn) {
                newMatrix[row, column - 1] = matrix[row, column];
            }
        }
    }
    return newMatrix;
}

//создание и вывод изначальной матрицы
int[,] originMatrix = generationNewMatrix();
Console.WriteLine("Изначальная матрица:");
printMatrix(originMatrix);
//поиск и вывод минимального элемента и его положения
int minimalElementRow = 0, minimalElementColumn = 0;
for (int row = 0; row < originMatrix.GetLength(0); row++) {
    for (int column = 0; column < originMatrix.GetLength(1); column++) {
        if (originMatrix[row, column] < originMatrix[minimalElementRow, minimalElementColumn]) {
            minimalElementRow = row;
            minimalElementColumn = column;
        }
    }
}
Console.WriteLine($"Минимальный элемент матрицы {originMatrix[minimalElementRow, minimalElementColumn]} расположен");
Console.WriteLine($"в строке: {minimalElementRow}");
Console.WriteLine($"в столбце: {minimalElementColumn}\n");
//удаление строки и столбца с минимальным элементом.
int[,] finalMatrix = removeColumn(removeRow(originMatrix, minimalElementRow), minimalElementColumn);
Console.WriteLine("Итоговая матрица:");
printMatrix(finalMatrix);