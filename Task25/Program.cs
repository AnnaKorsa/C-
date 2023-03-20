Console.Clear();
Console.Write("Введите число A: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int m = Convert.ToInt32(Console.ReadLine());
int exponent = n;
for (int i = 1;i < m; i++)
	exponent = exponent * n;
Console.WriteLine(exponent);
