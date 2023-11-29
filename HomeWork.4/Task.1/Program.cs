// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

while (true) {
    Console.Write("Введите число: ");
    string? inputLine = Console.ReadLine();
    if (inputLine == null) {
        continue;
    } else if (inputLine[0] == 'q')  {
        break;
    } else if (int.TryParse(inputLine, out int result)) {
        int sumDigits = 0;
        for (int index = 0; index < inputLine.Length; index++) {
            sumDigits += inputLine[index] - 48;
        }
        if (sumDigits % 2 == 0) {
            break;
        }
    }
}