// 12. Дан целочисленный двумерный массив, размерности n х m. Найти количество элементов кратных 7.

int[,] arr = new int[5, 5];
Random rnd = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(1, 100);
        Console.Write($"{arr[i, j],4}");

    }
        Console.WriteLine();
}
int count = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (arr[i, j] % 7 == 0)
        {
            count++;
        }
    }
}
Console.WriteLine(count);