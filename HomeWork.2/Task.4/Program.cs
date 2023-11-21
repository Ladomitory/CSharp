// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую

Console.Write("Your number: ");
string line = Console.ReadLine();
int number = Convert.ToInt32(line), lenOfNumber = line.Length;
int[] digitsFromNumber = new int[lenOfNumber];
for (int index = 1; index <= lenOfNumber; index++) {
    digitsFromNumber[lenOfNumber - index] = number % 10;
    number /= 10;
}
for (int index = 0; index < lenOfNumber; index++) {
    Console.Write(digitsFromNumber[index]);
    if (index < lenOfNumber - 1) {
        Console.Write(",");
    }
}