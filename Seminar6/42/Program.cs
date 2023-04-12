﻿// **Задача 42:**Напишите программу,
// которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10


Console.Clear();
Console.WriteLine("Введите ваше число в десятичной системе: ");
int number = int.Parse(Console.ReadLine()!);

string res = DecToNum(number, 2);// вместо двойки можно поставить любую другую систему исчисления.

Console.WriteLine($"{number}->{res}");

//Универсальный математический для перевода из 10 в любую
string DecToNum(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        res = nums[decNumber % otherSystem] + res;
        decNumber /= otherSystem;
    }
    return res;
}
