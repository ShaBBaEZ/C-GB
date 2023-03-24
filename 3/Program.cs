//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Clear();
Console.WriteLine("Введите номер дня в неделе, ");
int numberDayOfWeek = int.Parse (Console.ReadLine()!);

if(numberDayOfWeek < 1 || numberDayOfWeek > 7)//Указываем диапозон чисел которые нам не подойдут (|| - или)
{
    Console.WriteLine("Такого дня недели нет");
    return;
}

if(numberDayOfWeek==1){
    Console.WriteLine("Понедельник");
}if(numberDayOfWeek==2){
    Console.WriteLine("Вторник");
}if(numberDayOfWeek==3){
    Console.WriteLine("Среда");
}if(numberDayOfWeek==4){
    Console.WriteLine("Четверг");
}if(numberDayOfWeek==5){
    Console.WriteLine("Пятница");
}if(numberDayOfWeek==6){
    Console.WriteLine("Суббота");
}if(numberDayOfWeek==2){
    Console.WriteLine("Воскресенье");
}

