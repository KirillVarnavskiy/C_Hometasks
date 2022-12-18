// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Enter a five-digit number: ");
string? n = Console.ReadLine();
int n1 = 0;
// if (n!.Length != 5)
// Console.WriteLine("Entered number is not five-digit one, but");

for (int i = n.Length-1; i >= 0; i--)
{  
    n1 = n1 + Convert.ToInt32(int.Parse(n[i].ToString()) * Math.Pow(10, i));
}

if (n1 == int.Parse(n) && n!.Length == 5)
Console.WriteLine($"yes, number {n} is palindrome");

else if (n1 == int.Parse(n) && n!.Length != 5)
Console.WriteLine($"number {n} is palindrome, but not five-digit one");

else
Console.WriteLine($"no, number {n} is not palindrome");