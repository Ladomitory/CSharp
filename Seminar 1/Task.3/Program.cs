//Написать соответствие номера и дная недели

Console.Write("Номер дня недели: ");
int numberOfDays = Convert.ToInt32(Console.ReadLine());

// if (numberOfDays == 1) {
//     Console.WriteLine("Понедельник");
// } else if (numberOfDays == 2) {
//     Console.WriteLine("Вторник");
// } else if (numberOfDays == 3) {
//     Console.WriteLine("Среда");
// } else if (numberOfDays == 4) {
//     Console.WriteLine("Четверг");
// } else if (numberOfDays == 5) {
//     Console.WriteLine("Пятница");
// } else if (numberOfDays == 6) {
//     Console.WriteLine("Суббота");
// } else if (numberOfDays == 7) {
//     Console.WriteLine("Воскресенье");
// } else {
//     Console.WriteLine("Not day number");
// }

// switch (numberOfDays) {
//     case 1:
//         Console.WriteLine("Понедельник");
//         break;
//     case 2:
//         Console.WriteLine("Вторник");
//         break;
//     case 3:
//         Console.WriteLine("Среда");
//         break;
//     case 4:
//         Console.WriteLine("Четверг");
//         break;
//     case 5:
//         Console.WriteLine("Пятница");
//         break;
//     case 6:
//         Console.WriteLine("Суббота");
//         break;
//     case 7:
//         Console.WriteLine("Воскресенье");
//         break;
//     default:
//         Console.WriteLine("Not day number");
//         break;
// }

Dictionary<int, string> days = new Dictionary<int, string>() {
    { 1, "Понедельник" },
    { 2, "Вторинк" },
    { 3, "Среда" },
    { 4, "Четверг" },
    { 5, "Пятница" },
    { 6, "Суббота" },
    { 7, "Воскресенье" }
};
if (numberOfDays > 7 || numberOfDays < 1) {
    Console.WriteLine("Not day number");
} else {
    Console.WriteLine(days[numberOfDays]);
}