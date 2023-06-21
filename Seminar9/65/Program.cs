// Задача 65: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"




using System;
using static System.Console;

Clear();
Write("Введите первое число: ");
int first = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int second = int.Parse(ReadLine()!);
WriteNow(first,second);

void WriteNow(int i, int j)
{
    if(first <= second)
    {
        Write(first + " ");
        first++;
        WriteNow(first, second);
    }
}

