// Напишите программу, которая перевернёт одномерный массив
//(Последний элемент будет на первом месте, а первый на последнем и т.д)


Console.Clear();

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(String.Join(" ", ReversArray2(array)));
Console.WriteLine(String.Join(" ", array));
ReverseArray1(array);
Console.WriteLine(String.Join(" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReverseArray1(int[] inArray)//ничего не возвращает, меняет массив.Старый не сохраняется.
{
    for(int i = 0; i < inArray.Length / 2; i++)// деление на 2 позволит поменять массив только до половины, соответственно поменяется и вторая половина потому что меняем с ней.
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];// здесь меняем уже ячейки массива.
        inArray[inArray.Length - i - 1] = k;
    }
}

int[] ReversArray2(int[] inArray)// второй вариант решения переворота массива. При этом сам заданный масив у нас остаётся и мы создаём новый но уже перевёрнутый
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}
