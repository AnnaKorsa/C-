void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100); // [1, 99]
}
int SummPosition(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length;i += 2)
    {
        summ += array[i];
    }
    return summ;
}
Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine(SummPosition(array));
