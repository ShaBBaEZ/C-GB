// 20 Напишите программу,
// которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);

Console.WriteLine("Введите координату X первой точки: ");
double x1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y первой точки: ");
double y1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату X второй точки: ");
double x2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y второй точки: ");
double y2 = double.Parse(Console.ReadLine()!);

double s = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));//например формула:((3 - 2)^2 + (6 - 1)^2)
Console.WriteLine($"{s:f3}");//:f3 округление числа до 3 символов после запятой