//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

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

double FindLen(int x1, int y1, int x2, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2));
}

int x1 = ReaderData("Введите координату Х первой точки: ");
int y1 = ReaderData("Введите координату Y первой точки: ");
int z1 = ReaderData("Введите координату Z первой точки: ");
int x2 = ReaderData("Введите координату X второй точки: ");
int y2 = ReaderData("Введите координату Y второй точки: ");
int z2 = ReaderData("Введите координату Z второй точки: ");

double result = FindLen(x1, y1, z1, x2, y2, z2);
result = Math.Round(result, 2);
PrintData("Длинна отрезка : ", result.ToString());