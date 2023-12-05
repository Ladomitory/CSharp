// Задача 2:
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string GenerationString() {
    Random random = new Random();
    string newString = "";
    int stringLength = 10;
    for (int index = 0; index < stringLength; index++) {
        newString += (char) random.Next(33, 127);
    }
    return newString;
}

string ToLower(string originString) {
    string finalString = "";
    for (int index = 0; index < originString.Length; index++) {
        finalString += (char) (( originString[index] <= 'Z' && originString[index] >= 'A') ? (originString[index] + 'a' - 'A') : (originString[index]));
    }
    return finalString;
}

string originString = GenerationString();
Console.WriteLine(originString);
string finalString = ToLower(originString);
Console.WriteLine(finalString);