// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Enter the number: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2){
  Console.WriteLine($"The third digit of {Number} is " + NumberText[2]);
}
else {
  Console.WriteLine("The third digit is absent");
}
