// 26 Напишите программу,
// которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

int SumNumbers(int x){
    int count = 0;
    
    if(x < 0)
        x *= (-1);// тоже самое что x = x * (-1)
    while (x > 0)
    {
        x /= 10;// тоже самое что x = x / 10
        count++;    
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int s = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{SumNumbers(s)}");