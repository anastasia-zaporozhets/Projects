﻿// Напишите программу, которая принимает на вход случайно сгенерированное число (от 1 до 1 000 000)
// и проверяет, кратно ли оно одновременно 7 и 23.

int value = new Random().Next(1,1000000);
Console.WriteLine($"Случайное число = {value}");

if (value % 7 == 0 && value % 23 == 0)
{
    Console.WriteLine("Случайное число кратно 7 и 23");
}
else
{
    Console.WriteLine("Случайное число не кратно 7 и 23");
}        