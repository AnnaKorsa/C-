Console.Clear();
Console.WriteLine("Введите количество чисел: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите числа: ");
int[] array = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();
int count = 0;
foreach (int element in array)
{
    if (element > 0)
        count++;
}
Console.WriteLine(count);