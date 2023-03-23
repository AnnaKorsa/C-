
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11); // [1; 10]
}
Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write("Введите число К: ");
int K = Convert.ToInt32(Console.ReadLine());
if (K < 0) // Сдвиг влево
{
	for (int i = 0;i < Math.Abs(K);i++)
	{
		int b = array[0];
		for ( int j = 0; j <= n - 2; j++)
		{
			array[j] = array[j+1];
		}
		array[n - 1] = b;
	}
}
else // Сдвиг вправо
{
for (int i = 0;i < K;i++)
	{
		int b = array[n - 1];
		for ( int j = 0; j < n - 1; j++)
		{
			array[n-1 - j] = array[n-2 - j];
		}
		array[0] = b;
	}
}
Console.WriteLine($"Сдвиг массива : [{string.Join(", ", array)}]"); 

// Console.Clear();
// int[] array = { 5, 3, 7, 4, 6 };
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// int n = array.Length;
// Console.Write("Введите число К: ");
// int K = Convert.ToInt32(Console.ReadLine());
// if (K < 0) // Сдвиг влево
// {
// 	for (int i = 0;i < Math.Abs(K);i++)
// 	{
// 		int b = array[0];
// 		for ( int j = 0; j <= n - 2; j++)
// 		{
// 			array[j] = array[j+1];
// 		}
// 		array[n - 1] = b;
// 	}
// }
// else // Сдвиг вправо
// {
// for (int i = 0;i < K;i++)
// 	{
// 		int b = array[n - 1];
// 		for ( int j = 0; j < n - 1; j++)
// 		{
// 			array[n-1 - j] = array[n-2 - j];
// 		}
// 		array[0] = b;
// 	}
// }
// Console.WriteLine($"Сдвиг массива : [{string.Join(", ", array)}]"); 