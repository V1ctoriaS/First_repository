﻿// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число 
//квадратом второго
Console.Clear();
Console.Write("Введите первое число");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 == number2 * number2)
{
    Console.WriteLine("Yes");   
} 
else
{
    Console.WriteLine("No");
}