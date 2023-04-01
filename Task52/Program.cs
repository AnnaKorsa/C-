
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

void AverageValue(int[,] matrix, double[] array)
{
    for (int j = 0;j < matrix.GetLength(1);j++)
    {
        double average = 0;
        for (int i = 0;i < matrix.GetLength(0);i++)
        {
        average = average + matrix[i, j];
        }
        average = average / matrix.GetLength(0);
        array[j] = Math.Round(average, 2);
    }
	Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join(";  ", array)}");
}
	
Console.Clear();
Console.Write("Введите размеры двумерного массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
double[]array = new double[size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
AverageValue(matrix, array);


// void AverageValue(int[,] matrix)
// {
//     for (int j = 0;j < matrix.GetLength(1);j++)
//     {
//         double average = 0;
//         for (int i = 0;i < matrix.GetLength(0);i++)
//         {
//         average = average + matrix[i, j];
//         }
//         average = average / matrix.GetLength(0);
//         Console.Write(Math.Round(average, 2) + "; ");
//     }
// }

// Console.Clear();
// Console.Write("Введите размеры двумерного массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// Console.Write("Среднее арифметическое каждого столбца: ");
// AverageValue(matrix);