﻿/* Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру 
этого числа. */
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int B = (number / 10) % 10;
Console.WriteLine(B);