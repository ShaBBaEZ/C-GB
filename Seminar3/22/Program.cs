// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4

 Console.Clear();
 Console.WriteLine("Введите число: ");
// int X = int.Parse(Console.ReadLine()!);

// for(int y = 1; y <= X; y ++)
// {
//     double square = Math.Pow(y,2);
//     Console.WriteLine($"{square}");
// } ЭТО МОЁ РЕШЕНИЕ

int N = int.Parse(Console.ReadLine()!);
int[] result = new int[N];
for(int y = 1; y <= N; y ++)
    result[y - 1]= y*y;
for(int y = 0; y < N; y++)
    Console.Write($"{result[y]} ");


