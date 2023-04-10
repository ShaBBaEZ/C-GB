// Задайте массив из 12 элементов, заполненный случайнымы числами из промежудка [-9, 9]
// Найти сумму отрицательных и положительных элементов массива.

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue + 1);
    }

    return result;
}



int[] SumPosNeg(int[] array)
{
    int[] result = new int[2];
    foreach (int el in array)//[1,2,3,4,-5,1,-3] el = -5
    {
        //int a = el > 0& el : 0;
        //result[0] += a;
        result[0] += el > 0 ? el : 0;
        result[1] += el < 0 ? el : 0;
    }
    return result;
}


int[] array = GetRandomArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));
int[] r = SumPosNeg(array);
Console.WriteLine($"Positive sum ={r[0]}, negative sum = {r[1]}");
Console.WriteLine($"[ {String.Join(",", array)} ]");

