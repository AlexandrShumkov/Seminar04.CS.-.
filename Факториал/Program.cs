
int Fact(int n)
{
    if (n == 0 || n == 1) return 1;
    else return Fact(n - 1) * n;
}
Console.WriteLine(Fact(5));
