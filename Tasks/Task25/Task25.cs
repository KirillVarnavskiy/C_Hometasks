// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// НЕ ИСПОЛЬЗОВАТЬ Math.Pow

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Enter number A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number B");
int b = Convert.ToInt32(Console.ReadLine());
int result = a;

for (int i = 1; i < b; i++)
{
result = result * a;
}
Console.WriteLine("The result is: " + result);