// Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите размер матрицы: ");
string[] matrix = Console.ReadLine().Split();
int iCor = int.Parse(matrix[0]);
int jCor = int.Parse(matrix[1]);
if (iCor != jCor)
{
    Console.WriteLine("Такие матрицы нельзя перемножить, так как кол-во столбцов матрицы A не равно кол-ву строк матрицы B: ");
    return;
}
int[,] array1 = new int[iCor, jCor];
int[,] array2 = new int[iCor, jCor];

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
    // Console.WriteLine("Массив со случайными числами: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("Матрица A: ");
RandomArray(array1);
PrintArray(array1);
Console.WriteLine("Матрица B: ");
RandomArray(array2);
PrintArray(array2);
Console.WriteLine("Матрица C = A * B: ");
int[,] C = Multiplication(array1, array2);
PrintArray(C);

int[,] Multiplication(int[,] a, int[,] b)
{
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}
void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0}", $"{a[i, j]}\t");
        }
        Console.WriteLine();
    }
}                


  