Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 1000)
{
	n = n / 10;
}
if (n > 99)
	Console.WriteLine(n % 10);
else
	Console.WriteLine("Третьей цифры нет");