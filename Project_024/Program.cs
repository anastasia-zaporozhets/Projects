// Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

Console.WriteLine("Введите размер массива: ");
string[] matrix = Console.ReadLine().Split();
int iCor = int.Parse(matrix[0]);
int jCor = int.Parse(matrix[1]);
int[,] array = new int[iCor, jCor];

Random rnd = new Random();

void RandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }    
    }
}
void PrintArray(int[,] array)
{
    Console.WriteLine("Массив со случайными числами: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
RandomArray(array);
PrintArray(array);

int min = 999;
int count = 1;
int k = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int tmp = 0;
        tmp = array[i, j];
        // Console.WriteLine(tmp);
        sum += tmp;
    }
    Console.WriteLine($"Сумма равна {sum}");
    if (min < sum)
    {
        continue;
    }
    else if (min == sum)
    {
        k = i + 1;
        count += 1;
        continue;
    }
    else
    {
        min = sum;
        k = i + 1;
    }
    Console.WriteLine(sum);
}
Console.WriteLine($"Минимальное значение в строке {k}. Всего в массиве Минимальное значение встречается {count} раз.")                    