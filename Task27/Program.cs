Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int i = 0;
while ( n != 0 )
{
sum = sum + n % 10;
n = n / 10;
i++;
}
Console.WriteLine(sum);
