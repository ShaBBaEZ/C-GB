// /* **Задача 57:**Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

// { 1, 9, 9, 0, 2, 8, 0, 9 }

// 0 встречается 2 раза

// 1 встречается 1 раз

// 2 встречается 1 раз

// 8 встречается 1 раз

// 9 встречается 3 раза

// 1, 2, 3,4, 6, 1, 2, 1, 6

// 1 встречается 3 раза

// 2 встречается 2 раз

// 3 встречается 1 раз

// 4 встречается 1 раз

// 6 встречается 2 раза*\

// using System;
// using static System.Console;

// Clear();
// Write("Введите количество строк массива: ");
// int rows = int.Parse(ReadLine()!);

// Write("Введите количество столбцов массива: ");
// int columns = int.Parse(ReadLine()!);

// int[,] array = GetArray(rows,columns, 0 , 10);
// PrintArray(array);
// FrequencyDictionary(array,0,10);



// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             result[i,j] = new Random().Next(minValue,maxValue + 1);
//         }
//     }
//     return result;
// }


// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for(int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i,j]} ");
//         }
//         WriteLine();
//     }
// }

// void FrequencyDictionary (int[,] array, int minValue, int maxValue)
// {   
//     for(int x = 0; x <= maxValue; x++)
//     {   
//         int res = 0;
//         for(int i = 0; i < array.GetLength(0);i++)
//         {
//             for(int j = 0;j < array.GetLength(1);j++)
//             {
//                 if(array[i,j] == x)
//                 {
//                     res++;
//                 }
//             }
//         }
//         WriteLine($"Число {x} встречается в массиве {res} раз.");
//     }
// }

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
int[] rowAr = GetRowArray(array);
SortArray(rowAr);
WriteLine(String.Join(" ", rowAr));
PrintData(rowAr);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

int[] GetRowArray(int[,] inArray)// превращает двумерный массив в одномерный
{
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    int index = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[index] = inArray[i, j];
            index++;
        }
    }
    return result;
}

void SortArray(int[] inArray) // сортирует массив от меньшего к большему
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

void PrintData(int[] inArray)// вывод 
{
    int el = inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] != el)
        {
            WriteLine($"{el} встречается {count}");
            el = inArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    WriteLine($"{el} встречается {count}");
}