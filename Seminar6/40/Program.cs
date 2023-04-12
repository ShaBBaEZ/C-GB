// **Задача 40:**Напишите программу,
// которая принимает на вход три числа и проверяет, может ли
// существовать треугольник с сторонами такой длины.


// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Введите первую сторону треугольника: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второю сторону треугольника: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите третью сторону треугольника: ");
// int c = int.Parse(Console.ReadLine()!);

// Console.WriteLine(Triangle(a,b,c));




// string Triangle (int a,int b,int c)
// {
//     if(a < b + c && b < a + c && c < a + b)
//     {
//     return "Такой треугольник может существовать";
//     }
//     else
//     {
//         return "Такой треугольник не может существовать.";
//     }

// }
// ЭТО ВСЁ МОЁ РЕШЕНИЕ

Console.Clear();
Console.Write("Введите стороны треугольника через пробел: ");

string[] st = Console.ReadLine()!.Split(' ');// Разделяем строку на массив между которыми стоит пробел.
int a = int.Parse(st[0]);
int b = int.Parse(st[1]);
int c = int.Parse(st[2]);

if(IsTriangle(a,b,c))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

bool IsTriangle(int a, int b , int c)
{
    return(((a + b) > c) && ((a + c) > b) && ((c + b) > a));
}


