// Найдите сумму произведений пар чисел в одномерном целочисленном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Если кол-во элементов нечетное, то элемент посередине не учитывать.
// Результат сложения вывести на экран.
// 1, 3, 8, 3, 2 -> 11
// 8, 3, 4, 2 -> 28

Console.Write("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

int composition = 1;
int sum = 0;

for (int i = 0; i < (n); i++)
{
    array[i] = new Random().Next(1, 10);
}
for (int i = 1; i <= (n / 2); i++)
{
    composition = array[i - 1] * array[n - i];
    sum += composition;
}
Console.WriteLine($"Сумма произведений пар чисел = {sum}");        