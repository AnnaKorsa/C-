// Двумерный массив размером m×n, заполненный случайными вещественными числами.
void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Math.Round(new Random().NextDouble() * (10 - 0) +0, 1); // [-10, 10]
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine()!);
double[,] matrix = new double[m, n];
InputMatrix(matrix);
PrintMatrix(matrix);