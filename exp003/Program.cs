// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.

Console.Write("Введи трехзначное число: ");
int number=int.Parse(Console.ReadLine());
int number2=number%10;
Console.Write(number2); //($"Псоледняя цифра числа {number}");