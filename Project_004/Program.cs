// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все четные числа от 1 до N.
// 5 -> 2,4
// 8 -> 2,4,6,8

Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = int.Parse(Console.ReadLine());
for (int i = n; i <= m; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.ReadKey();        