// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// 3 -> Среда
// 5 ->  Пятница


Console.Write("Введите любое число: ");
int x=int.Parse(Cosole.ReadLine());
if (x==1)
{
    Console.Write("Понедельник");
}
if (x==2)
{
    Console.Write("Вторник");
}
if (x==3)
{
    Console.Write("Среда");
}
if (x==4)
{
    Console.Write("Четверг");
}
if (x==5)
{
    Console.Write("Пятница");
}
if (x==6)
{
    Console.Write("Суббота");
}
if (x==7)
{
    Console.Write("Воскресенье");
}
else (x<0) and (x>7);
{
    Console.Write("Такого дня недели нет");
}