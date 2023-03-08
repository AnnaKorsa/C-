Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n > m)
    Console.WriteLine($"max = {n}");
else if (n < m)
    Console.WriteLine($"max = {m}");
else
    Console.WriteLine("=");
