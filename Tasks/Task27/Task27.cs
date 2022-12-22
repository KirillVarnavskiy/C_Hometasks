// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Enter the number: ");
int Number = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int Number){
    
    int counter = Convert.ToString(Number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = Number - Number % 10;
      result = result + (Number - advance);
      Number = Number / 10;
    }
   return result;
  }

int sumNumber = SumNumber(Number);
Console.WriteLine("Sum of digits in the number: " + sumNumber);