// Напишите программу замены элементов массива:
//положительные элементы замените на соотствующие отрицательные и наоборот.
//[-4, -8 ,8 ,2]->[4,8,-8,2] String.Join(",", array)*/

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue + 1);
    }

    return result;
}

int[] InversArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

int[] array = GetRandomArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));
int[] r = InversArray(array);
Console.WriteLine(String.Join(", ", r));
