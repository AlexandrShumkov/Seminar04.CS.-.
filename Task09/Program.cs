// 9. Дан целочисленный двумерный массив, размерности n х m. Выяснить, какое число встречается в какой строке раньше — положительное или отрицательное.

Random rnd = new Random();
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(-100, 100);
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

void WhichNumberFirst(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > 0)
            {
                Console.WriteLine("Положительное");
                break;
            }
            if (arr[i, j] < 0)
            {
                Console.WriteLine("Отрицательное");
                break;
            }
        }
    }
}
int[,] arr = new int[5, 5];
FillArray(arr);
PrintArray(arr);
WhichNumberFirst(arr);