//30 Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.

// //[1,0,1,1,0,1,0,0]
// int a = new Random().Next(2, 7);
// int b = new Random().Next(2);
// Console.WriteLine($"a = {a},b = {b}");

int[] GetBinaryArray(int size){
    int[] result = new int[size];//Формируем новый массив где size-кол во элементов
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);//на каждый элемент радом записываем рандомное число 0 или 1(двйока не учитывается)
    }
    return result;
}


int[] array = GetBinaryArray(8);
Console.WriteLine($"[{String.Join(" ", array)}]");//позволяет соединять все элементы массива array со строкой т.е в нашем случае это запятая. 
