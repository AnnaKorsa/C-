void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}
void SumElementString(int[,] matrix, int[] array)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        array[i] = sum;
    }
}
void FindMinValue(int[] array)
{
    int min = array[0];
    int index =0;
    for (int i = 1;i < array.Length;i++)
    {
        if(min > array[i])
        {
            min = array[i];
            index = i + 1;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов:{index}");
}
Console.Clear();
Console.Write("Введите число строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
int[] array = new int[n];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
SumElementString(matrix, array);
FindMinValue(array);


