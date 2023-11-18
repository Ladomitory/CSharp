// Напишите программу которая на вход получает число, а возвращает его квадврат

//number - получаемое число, result - результат вычислений
long number, result;
Console.Write("Your number: ");
// получение изначального числа
number = long.Parse(Console.ReadLine());
//вычисление результата
result = number * number;
Console.WriteLine("Rasult: " + result);