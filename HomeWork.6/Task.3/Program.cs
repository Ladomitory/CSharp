// Задача 3: 
// Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

string GenerationString() {
    Random random = new Random();
    string newString = "";
    int stringLength = random.Next(1, 10);
    for (int index = 0; index < stringLength; index++) {
        newString += (char) random.Next(33, 127);
    }
    return newString;
}

string originString = GenerationString();
bool polindrom = true;
for (int index = 0; index < originString.Length; index++) {
    if (originString[index] != originString[originString.Length - 1 - index]) {
        polindrom = false;
        break;
    }
}
Console.WriteLine(originString);
Console.WriteLine((polindrom) ? ("It\'s polindrom") : ("It isn\'t polindrom"));