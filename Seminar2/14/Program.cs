// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Clear();
Console.Write("Введите число, ");
int number = int.Parse(Console.ReadLine()!);
if (0 == number % 7 && 0 == number % 23)
{
    Console.WriteLine($"{number}-> Да");
}
else
{
    Console.WriteLine($"{number}-> нет");
}
