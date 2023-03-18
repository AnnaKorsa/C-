Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = n;
int res = 0;
while (n > 0)
{
    res = res * 10 + n % 10;
	n = n / 10;
}
if(temp == res)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");
