// Задача №5. Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Your number: ");
int N = Convert.ToInt32(Console.ReadLine());

// int negativN = -N;
// while (negativN <= N) {
//     Console.Write(negativN + " ");
//     negativN += 1;
// }

// int negativN = -N;
// do {
//     Console.Write(negativN + " ");
//     negativN += 1;
// } while (negativN <= N);

for (int negativN = -N; nagativN <= N; negativN += 1) {
    Console.Write(negativN + " ");
}