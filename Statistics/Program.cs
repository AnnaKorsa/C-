void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32); // [1, 31]
}

int EvenDays(int[] array)
{
	int count = 0;
    for (int i = 0; i < array.Length;i++)
    {
		if (array[i] % 2 ==0)
		{
			Console.Write($"{array[i]} ");
			count++;
		}
	}
	Console. WriteLine("\n");
	return count;
}
int OddDays(int[] array)
{
  	int account = 0;
    for (int i = 0; i < array.Length;i++)
    {
    	if (array[i] % 2 == 1)
		{
			Console.Write($"{array[i]} ");
			account++;
		}
    }
    return account;
}
Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
if (EvenDays(array) >= OddDays(array))
	Console.WriteLine("\nYES");
else
 	Console.WriteLine("\nNO");
