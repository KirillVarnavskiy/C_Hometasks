// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Enter the number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number 3: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Max(a, Math.Max(b, c)));
