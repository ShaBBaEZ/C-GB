//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженноена само себя).
Console.Clear();//Clear-библиотека, помогает очищать терминал
Console.Write("Введите число, ");
int number = int.Parse(Console.ReadLine()!);//int.Parse перевод из строки в число
int sqr = number * number;
Console.WriteLine($"Квадратный корень числа {number} равен {sqr}");//$ позволяет в строке хранить переменную
int sqr1 = Convert.ToInt32(Math.Pow(number, 2));//второй вариант решения
Console.WriteLine($"Квадратный корень числа {number} равен {sqr}");
