// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Enter the coordinates of point A");
double X1 = Convert.ToDouble(Console.ReadLine());
double Y1 = Convert.ToDouble(Console.ReadLine());
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinates of point B");
double X2 = Convert.ToDouble(Console.ReadLine());
double Y2 = Convert.ToDouble(Console.ReadLine());
double Z2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt((Math.Pow(X1-X2,2))+Math.Pow(Y1-Y2,2)+Math.Pow(Z1-Z2,2));
Console.WriteLine($"The distance between points; {Math.Round(result, 2)}");