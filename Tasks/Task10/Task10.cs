// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Enter a three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n/10;
int n2 = n1 % 10;
Console.WriteLine($"The second digit of {n} is "+n2);