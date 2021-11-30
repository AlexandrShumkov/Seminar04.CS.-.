// 11. Дан целочисленный двумерный массив, размерности n х m. Вывести его элементы, индексы которых являются степенями двойки (1, 2, 4, 8, 16, ...).

Random rnd = new Random();
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 20);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4}");
        }
        Console.WriteLine();

    }
}

void FindElementsPow2(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for(int n=1;n<arr.Length/2;n++)
            {
            if ( Math.Pow(2, n)==i || Math.Pow(2, n)==j)
            {
                Console.Write(arr[i, j] + " ");
            }
        }
    }
}
}

int[,] arr = new int[10, 10];
FillArray(arr);
PrintArray(arr);
FindElementsPow2(arr);