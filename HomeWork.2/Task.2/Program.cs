// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

int kaordinateX, kaordinateY;
Console.Write("kaordinate X: ");
kaordinateX = Convert.ToInt32(Console.ReadLine());
Console.Write("kaordinate Y: ");
kaordinateY = Convert.ToInt32(Console.ReadLine());
if (kaordinateX > 0 && kaordinateY > 0) {
    Console.WriteLine("I четверть");
} else if (kaordinateX < 0 && kaordinateY > 0) {
    Console.WriteLine("II четверть");
} else if (kaordinateX < 0 && kaordinateY < 0) {
    Console.WriteLine("III четверть");
} else if (kaordinateX > 0 && kaordinateY < 0) {
    Console.WriteLine("IV четверть");
} else {
    Console.WriteLine("Error: one or two numbers equal 0;");
}