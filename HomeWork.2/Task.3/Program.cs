// Задача 3: Напишите программу, которая выводит третью с начала
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 6
// 91 => Третьей цифры нет

Console.Write("Your number: ");
string line = Console.ReadLine();
int number = Convert.ToInt32(line), lenOfNumber = line.Length;
if (lenOfNumber < 3) {
    Console.WriteLine("Третьей цифры нет");
} else {
    int divider = 1;
    for (int index = 0; index < lenOfNumber - 3; index++) {
        divider *= 10;
    }
    int result = (number / divider) % 10;
    Console.WriteLine(result);
}