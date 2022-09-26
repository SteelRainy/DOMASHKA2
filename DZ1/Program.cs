/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

//Ввод
int ReaderData(string line)
{
    Console.WriteLine(line);
    int num = int.Parse(Console.ReadLine() ?? "");
    return num;
}
//Вывод
void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}


string IsPolindrom(int n)
{
    int temp = n;
    int rev = 0;
    while (temp > 0)
    {
        int dig = temp % 10;
        rev = rev * 10 + dig;
        temp /= 10;
    }
    return rev == n ? $"{n} -> да" : $"{n} -> нет";
}

//Программ.
int number = ReaderData("Введите пятизначное число: ");
if (number > 1000000 && number < 10 && number < 100 && number < 1000)
{
    PrintData("Такой цифры нет", "");
}
else
{
    string palidrom = IsPolindrom(number);
    PrintData("Введеное вами число: ", palidrom.ToString());
}



