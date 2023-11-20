//Напишите программу которая выводит случайное число из диапазона [10, 99]
//и показывает наибольшую цивру этого числа

// Random().Next -> [a, b)
int MaxDigit(int number) {
    int firstDigit = number / 10, secondDigit = number % 10;
    return (firstDigit >= secondDigit) ? (firstDigit) : (secondDigit);
}

int number = new Random().Next(10, 100);
Console.Write(number + " -> ");
int result = MaxDigit(number);
Console.WriteLine(result);