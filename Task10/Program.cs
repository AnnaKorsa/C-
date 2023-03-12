Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 99 || n > 1000)
{
	Console.WriteLine("Вы ошиблись!\nВведите трехзначное число: ");
	n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine((n / 10) % 10);

