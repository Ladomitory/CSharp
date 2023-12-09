// Задача 2: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int AkkermanFunction(int coefficientN, int coefficientM) {
    if (coefficientN == 0) {
        return coefficientM + 1;
    } else if (coefficientM == 0) {
        return AkkermanFunction(coefficientN - 1, 1);
    } else {
        return AkkermanFunction(coefficientN - 1, AkkermanFunction(coefficientN, coefficientM - 1));
    }
}

Console.Write("Введите коэффициэнты в формате 'N M': ");
string[] input = Console.ReadLine().Split(" ");
Console.WriteLine(AkkermanFunction(Convert.ToInt32(input[0]), Convert.ToInt32(input[1])));