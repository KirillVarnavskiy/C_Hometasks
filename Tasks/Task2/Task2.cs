// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Enter the number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number 2: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
   Console.Write($"number {a} greater than number {b}");
else if (a < b)
   Console.Write($"number {b} greater than number {a}");
 
