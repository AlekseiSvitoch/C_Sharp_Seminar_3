﻿// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= number)
{
    Console.Write($"{i * i} ");
    i++;
}

// Console.Clear();
// Console.Write("Ведите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// Console.Write($"{i * i} ");