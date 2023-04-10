// Задайте массив.Напишите программу,
// которая определяет, присутствует ли заданное число в массиве.

// 4; массив[6, 7, 19, 345, 3]->нет
// 3; массив[6, 7, 19, 345, 3]->да*/

Console.WriteLine("Введите элементы массива через пробел: ");
string elements = Console.ReadLine()!;
int[] baseArray = GetArrayFromString(elements);
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

if(FindElemet(baseArray,n))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ");// разделяет строчки на элементы массива между которыми стоит пробел
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

bool FindElemet(int[] array, int el)
{
    foreach (var item in array)
    {
        if (el == item) return true;
    }
    return false;
}

