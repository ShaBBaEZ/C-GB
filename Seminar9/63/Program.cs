// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"




using System;
using static System.Console;

Clear();
Write("Введите значение N: ");
int N = int.Parse(ReadLine()!);
WriteNow(N,1);

void WriteNow(int N, int i)
{
    if(i <= N)
    {
        Write(i + " ");
        i++;
        WriteNow(N, i);
    }
}



