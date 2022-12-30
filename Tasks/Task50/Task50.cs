﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет

Console.WriteLine("Enter the number of the row");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of the column");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [3,4];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("There is no such element in the array");
}
else
{
    Console.WriteLine($"the value of {n} row and {m} column is {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
               for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }   
        Console.Write("");
        Console.WriteLine(""); 
    }
}