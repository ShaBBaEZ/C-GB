// напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. если второе число не кратно числу превому, то программа выводит остаток от деления.

Console.Clear();
Console.Write("Введите первое число, ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число, ");
int number2 = int.Parse(Console.ReadLine()!);
if (number1 % number2 == 0)
{
    Console.WriteLine($"Число {number2} является кратным числа {number1}");
}
else
{
    Console.WriteLine($"остаток от деления {number1 % number2}");
}
