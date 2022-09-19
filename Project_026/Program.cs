// Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
//Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34

Console.WriteLine("Введите размер матрицы: ");
string[] matrix = Console.ReadLine().Split();
int iCor = int.Parse(matrix[0]);
int jCor = int.Parse(matrix[1]);
if (iCor * jCor > 50)
{
    Console.WriteLine("Количество элеентов заданного массива превышает допустимое значение. Введите массив не превышающий 50 элементов: ");
    return;
}
int[,] array1 = new int[iCor, jCor];
Random rnd = new Random();

int FoundNumber(int[,] array, int number)
{
    int countRepeatNumb = 0;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            if (array[m, k] == number)
            {
                countRepeatNumb++;
            }
        }
    }
}
void RandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)   
        {
            array[i, j] = rnd.Next(10, 100);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0}", $"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
int[,] results = new int[iCor, jCor];
// Console.WriteLine("Массив со случайными числами: ");
for (int i = 0; i < results.GetLength(0); i++)
{
    for (int j = 0; j < results.GetLength(1); j++)
    {
        int tmpNumb = rnd.Next(10, 100);
        int SearchPepeatedNumber = FoundNumber(results, tmpNumb);
        // Console.Write($"{tmpNumb}\t");
        if (SearchPepeatedNumber > 0)
        {
            j--;
        }
        else
        {
            results[i, j] = tmpNumb;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("Готовый массив: ");
RandomArray(results);
PrintArray(results);                                                