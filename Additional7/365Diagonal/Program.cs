
void InputMatrix(int[,] matrix)
{
    int count = 0;
    for (int k = 0; k < matrix.GetLength(1) + matrix.GetLength(0);k++)
    {
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i + j == k)
                {
			    matrix[i, j] = count;
                count ++;
                }
            }
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите размеры двумерного массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);