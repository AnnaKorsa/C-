Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i < n-1)
{
	i += 2;
	Console.Write($"{i}, ");
}
