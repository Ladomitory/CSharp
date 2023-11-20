//Напишите программу которая генерирует случайное троехзначное число
//и вырезает из него среднюю цифру
//[100, 999]

int CutSecondDigit(int number) {
    return Convert.ToInt32(
        Convert.ToString(number/100) //first digit
        + Convert.ToString(number % 10) //third digit
        );
}

int number = new Random().Next(100, 1000);
Console.Write(number + " -> ");
int result = CutSecondDigit(number);
Console.WriteLine(result);