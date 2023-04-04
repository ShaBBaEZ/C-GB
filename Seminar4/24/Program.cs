//Напишите программу, которая принимает на вход число А
// и выдаёт сумму чисел от 1 до А
// а = 5
// sum = 1+2+3+4+5

int GetSum(int n){
    int sum = 0;
    for (int i = 1; i <= n; i++)
        sum +=i;// или sum = sum + i
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int a = GetSum(n);//возможно лишняя строка от которой ничего не изменится
Console.WriteLine($"Сумма от 1 до {n} равна {GetSum(n)}");

