// Задача 1: Задайте значения M и N.
// Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void PrintRange(int start, int final) {
    Console.Write($"{start} ");
    if (start < final) {
        PrintRange(start + 1, final);
    }
}

Console.Write("Введите начало промежутка: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец промежутка: ");
int lastNumber = Convert.ToInt32(Console.ReadLine());
PrintRange(firstNumber, lastNumber);