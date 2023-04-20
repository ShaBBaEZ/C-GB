/*Задача 59: Из двумерного массива целых чисел удалить строку и столбец,
на пересечении которых расположен наименьший элемент.*/

using System;
using static System.Console;

Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows,columns, 0 , 100);
PrintArray(array);
WriteLine();
WriteLine($"минимальный элемент находится - > {String.Join(" ", GetIndexMinEl(array))}");
WriteLine();
PrintArray(GetResultArray(array, GetIndexMinEl(array)));


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

int[] GetIndexMinEl(int[,] inArray)
{
    int[] result = new int[] {0, 0};
    int min = inArray[0 , 0];
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            if (min > inArray[i,j])
            {
                min = inArray[i,j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}
int[,] GetResultArray( int[,] inArray, int[] indexes)
{
   int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];// Создаём массив меньше на 1 строку и столбец чем наш изначальный так как они должны удалиться
   int row = 0;
   int column = 0;
   for(int i = 0; i < inArray.GetLength(0); i++)
   {
        if(i == indexes[0])
            continue;
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            if(j == indexes[1])
                continue;
            result [row,column] = inArray[i,j];
            column++;
        }
        column = 0;
        row++;
   }
   return result;
}

