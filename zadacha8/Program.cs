﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int num = 1;

for (int i = num; i <= n; i++)
{
if (i % 2 == 0)
{
Console.Write(i + " ");
}
}
