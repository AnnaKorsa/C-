Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ое число: ");
int k = Convert.ToInt32(Console.ReadLine());
int max = n;

if (m > max) max = m;
if (k > max) max = k;
	Console.WriteLine(max);