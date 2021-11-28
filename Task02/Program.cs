//Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение всех четных элементов массива

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Random rnd = new Random();
            arr[i, j] = rnd.Next(1, 10);
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

void Task02(int[,] arr, out int sum, out int multi)
{
    sum = 0; multi = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            if (arr[i, j] % 2 == 0)
            {
                sum = sum + arr[i, j]; multi = multi * arr[i, j];
            }


        }
    }
}

int[,] arr = new int[2, 2];


FillArray(arr);
PrintArray(arr);
int s; int m;

Task02(arr, out s, out m);
Console.Write($"Сумма четных: {s},Произведение  четных: {m}");