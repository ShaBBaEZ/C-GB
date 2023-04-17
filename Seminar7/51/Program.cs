// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, находящихся
// на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12



using System;
using static System.Console;

Clear();
Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);

int[,] array = GetArray(rows,columns, 0 , 10);
PrintArray(array);
WriteLine($"Сумма элементов: {SumElementMainDiagonal(array)}");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)


{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

int SumElementMainDiagonal(int[,] array)
{
    int sum = 0;
    int i = 0;
    int j = 0;
    {
        while(i < array.GetLength(0) && j < array.GetLength(1))
        {
            sum += array[i,j];
            i++;
            j++;
        }
    }
    return sum;
}

// int GetSumDiag(int[,] array)                  ЭТО ВСЁ РЕШЕНИЕ ПРЕПОДАВАТЕЛЯ.
// {
// int length = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
// // if (array.GetLength(0) < array.GetLength(1))
// // length = array.GetLength(0);
// // else
// // length = array.GetLength(1);
// int sum = 0;
// for (int i = 0; i < length; i++)
// {
// sum += array[i, i];
// }
// return sum;
// }