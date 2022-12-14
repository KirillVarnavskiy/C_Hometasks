// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100){
  Console.WriteLine("The third digit is absent");
}
else 
{while (n > 1000)
        n = n / 10;

  Console.WriteLine(n % 10);
}
