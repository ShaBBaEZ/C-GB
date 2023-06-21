// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


using System;
using static System.Console;

Clear();

WriteLine("Введите число: ");
int number = int.Parse(ReadLine()!);
WriteLine(SumNumber(number));

int SumNumber(int i)
{
    if (i == 0)
        return 0;
    return (i % 10 + SumNumber(i / 10));
}