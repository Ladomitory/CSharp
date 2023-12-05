// Задача 1: 
// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

char[,] GenerationNewmatrix() {
    Random random = new Random();
    char[,] matrix = new char[random.Next(1, 5), random.Next(1, 5)];
    for (int row = 0; row < matrix.GetLength(0); row++) {
        for (int column = 0; column < matrix.GetLength(1); column++) {
            matrix[row, column] = (char) random.Next(33, 127);
        }
    }
    return matrix;
}

void PrintMatrix(char[,] matrix) {
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

char[,] charMatrix = GenerationNewmatrix();
PrintMatrix(charMatrix);
string stringFromCharMatrix = "";
for (int row = 0; row < charMatrix.GetLength(0); row++) {
    for (int column = 0; column < charMatrix.GetLength(1); column++) {
        stringFromCharMatrix += charMatrix[row, column];
    }
}
Console.WriteLine(stringFromCharMatrix);