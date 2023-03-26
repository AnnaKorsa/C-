Console.Clear();
Console.WriteLine("Введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = 0;double y = 0;
if (k1 == k2 && b1 == b2)
    Console.WriteLine("Прямые совпадают");
else if (k1==k2)
    Console.WriteLine("Прямые параллельны");
else
{
    x=(b2-b1)/(k1-k2);
    y=(k1*(b2-b1))/(k1-k2)+b1;
    Console.WriteLine($"Прямые пересекутся в точке с координатами X: {Math.Round(x, 2)} Y: {Math.Round(y, 2)}");
}
