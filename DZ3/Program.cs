//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//Ввод
int ReaderData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

//Вывод
void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

string LineNum(int numN, int p)
{
    string outLine = "1";
    for (int i = 2; i <= numN; i++)
    {
        outLine = outLine + " " + Math.Pow(i, p);
    }
    return outLine;
}
int numN = ReaderData("Введите число N: ");

string lineTop = LineNum(numN, 1);
string lineDown = LineNum(numN, 3);
PrintData("", lineTop);
PrintData("", lineDown);
