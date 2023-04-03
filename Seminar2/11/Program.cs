// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

Console.Clear();
//int num = new Random().Next(100, 999); МОЁ решение
//Console.WriteLine(num);
//int a1 = num % 10;
//int a2 = num / 10;
//int a3 = a2 / 10;

//Console.WriteLine($"{a3}{a1}");

int num = new Random().Next(100, 1000);
int result = (num/100) * 10 + num % 10;
Console.WriteLine($"{num}->{result}");
Console.WriteLine($"{num}->{num/100}{num%10}");