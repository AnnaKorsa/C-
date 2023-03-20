void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    	array[i] = Math.Round(new Random().NextDouble() * (30 - 20), 2); // [0, 10]
}
Double MaxMin(double[] array)
{
	double min = array[0];
	double max = array[0];
	int i = 1;
	while (i < array.Length)
	{
		if (max<array[i])
			max = array[i];
		if (min>array[i])
			min = array[i];
		i++;
	}
	return max-min;
}
Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join("  ", array)}]");
Console.WriteLine(MaxMin(array));