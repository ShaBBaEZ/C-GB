// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


using System;
using static System.Console;

Clear();

WriteLine("Введите число A: ");
int A = int.Parse(ReadLine()!);

WriteLine("Введите число B: ");
int B = int.Parse(ReadLine()!);
Write(Degree(A,B));
int Degree (int i, int j)
{
    if (j == 0)
        return 1;
    return Degree(i, --j) * i;
}

