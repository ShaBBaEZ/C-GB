//28 Напишите программу, которая принимает на вход число N
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

int GetMul(int x){
    int mul = 1;
    for(int i = 2;i <= x; i++){
        mul *= i;
    }
    return mul;
}

//Console.Clear();
Console.WriteLine("Введите число: ");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine($"произведение чисел от 1 до {y} = {GetMul(y)}");
