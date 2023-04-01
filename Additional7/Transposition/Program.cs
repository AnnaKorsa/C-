// Транспонирование - 4


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
void ReplaceRow(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0) / 2; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
		{
        int temp = matrix[i, j];
        matrix[i, j] = matrix[matrix.GetLength(0) - 1 - i, j];
        matrix[matrix.GetLength(0) - 1 - i, j] = temp;
   	 	}
	}
}
Console.Clear();
Console.Write("Введите размеры двумерного массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
ReplaceRow(matrix);

Console.WriteLine("Транспонированная матрица относительно горизонтали: ");
PrintMatrix(matrix);