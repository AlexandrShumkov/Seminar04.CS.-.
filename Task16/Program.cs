// 16. Дан целочисленный двумерный массив, размерности n х m. Заменить все элементы на их квадраты.


Random rnd = new Random();
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 110);
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
Console.ReadKey();
}
void ChangeArray(int[,] arr)
{
    for(int i=0;i<arr.GetLength(0);i++)
    {
        for(int j=0;j<arr.GetLength(1);j++)
        {
           Console.Write($"{Math.Pow(arr[i,j],2),8}");
        }
        Console.WriteLine();
    }
       
}

int[,] arr=new int[5,5];
FillArray(arr);
PrintArray(arr);
ChangeArray(arr);

