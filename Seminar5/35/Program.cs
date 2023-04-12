/* **Задача 35:**Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2]-> 0

[10, 11, 12, 13, 14]-> 5

*/


Console.Clear();
int[] startArray = GetArray(123, 0 , 200);
Console.WriteLine(String.Join(" ", startArray));//Выводим массив между элементами ставим пробел
Console.WriteLine($"Количество элементов в отрезке от [10;99] = {GetCountElements(startArray, 10 ,99)}");

int[] GetArray(int size, int minValue, int maxValue)////Создаём массив 123 элемент от 0 до 200
{
    int[] res = new int[size];
    
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue,maxValue + 1);
    }
    return res;
}

int GetCountElements(int[] array, int leftRange, int rigthRange)//l = 10 r = 99
{
    int count = 0;
    foreach(int item in array)
    {
        if(item>= leftRange && item <= rigthRange) count++;
    }
    return count;
}