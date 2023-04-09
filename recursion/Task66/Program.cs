int f(int m, int n)
{
    if (m == n)
        return m;
    return f(m, n - 1) + n;
}


Console.Clear();
Console.Write("Введите начальное число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(m, n));