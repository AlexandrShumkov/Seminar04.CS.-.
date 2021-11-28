// 1.  Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение всех элементов массива
void SetArray2D(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Random rnd = new Random();
            a[i, j] = rnd.Next(1, 5);
        }
    }
}


void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($"{a[i, j],4}");
        }
        Console.WriteLine();
    }
}

// Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение всех элементов массива
void Task01(int[,] a, out int sum, out int multi)
{
    sum = 0;
    multi = 1;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            sum = sum + a[i, j];
            multi = multi * a[i, j];
        }

    }
}


//Main
int[,] a;//ссылочный тип (references)
a = new int[2, 2];

Print(a);
SetArray2D(a);
Console.ReadKey();
Console.Clear();
Print(a);
SetArray2D(a);
int s, m;
Task01(a, out s, out m);
Console.WriteLine($"Сумма {s},Произведение{m}");