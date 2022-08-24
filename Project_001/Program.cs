// Напишите программу, которая на вход принимает два числа и выдает,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a2 = 2; b2 = 10 -> max = 10
// a3 = -9; b3 = -3 -> max = -3

int a = 5;
int b = 7;
int a2 = 2;
int b2 = 10;
int a3 = -9;
int b3 = -3;
int max = b;

if (a < max) max = b;
Console.WriteLine (max);

if (a2 < max) max = b2;
Console.WriteLine (max);

if (a3 < max) max = b3;
Console.WriteLine (max);