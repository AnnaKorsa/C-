// Перестановки

// Дана строка, состоящая из N попарно различных символов. 
// Требуется вывести все перестановки символов данной строки.

void Permutation(string[] array, int n)
{
	if (n == 1)
	{
		Console.WriteLine($"{string.Join("", array)}");
		return;
	}
	for (int i = 0;i < n;i++)
	{
		Permutation(array, n - 1);
		if (n % 2 == 0)
		{
			string temp = array[i];
			array[i] = array[n - 1];
			array[n - 1] = temp;
		}
		else
		{
			string temp = array[0];
			array[0] = array[n - 1];
			array[n - 1] = temp;
		}
	}
}
Console.Clear();
Console.WriteLine("Введите количество: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите числа: ");
string[] array = Console.ReadLine()!.Split().ToArray();
Permutation(array, n);