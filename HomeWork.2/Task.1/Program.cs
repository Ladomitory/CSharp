// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// Квадрат в ОБЕ стороны.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

string[] numbers = Console.ReadLine().Split(", ");
int firstNumber = Convert.ToInt32(numbers[0]), secondNumber = Convert.ToInt32(numbers[1]);
if (firstNumber * firstNumber == secondNumber || firstNumber == secondNumber * secondNumber) {
    Console.WriteLine("да");
} else {
    Console.WriteLine("нет");
}