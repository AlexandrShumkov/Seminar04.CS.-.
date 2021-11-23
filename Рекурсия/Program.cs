// Рекурсия.Вывести на экран числа от 1 до 10,не используя циклы.

void Loop(int i)
{
    Console.Write($"{i} ");
    if(i<10) Loop(i+1);
}
Loop(1);