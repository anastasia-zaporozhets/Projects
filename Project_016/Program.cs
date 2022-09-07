// SЗадайте одномерный массив, заполненный случайными числами. Найдите сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).
// [3, 7, 23, 12] -> 12
// [4, 6, 8, 1, 4] -> 6

Console.WriteLine("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int sumNumbers = 0;

for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(1,100);
    Console.WriteLine(array[i]);
    if (array[i] % 2 == 0 && i % 2 != 0)
    {
        sumNumbers += array[i];
    }
    Console.WriteLine(String.Join(",", array));
}
Console.WriteLine(sumNumbers);       
