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
void MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] outputMatrix)
{
  for (int i = 0; i < outputMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < outputMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      outputMatrix[i,j] = sum;
    }
  }
}

Console.Clear();
Console.Write("Введите число строк 1-й матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов 1-й матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число строк 2-й матрицы: ");
int m1 = Convert.ToInt32(Console.ReadLine());
while (m1 != m)
{
Console.WriteLine("\nОшибка!\nУмножать матрицы можно тогда и только тогда,когда количество столбцов первой матрицы равно количеству строк второй матрицы. ");
Console.Write("Введите число строк 2-й матрицы: ");
    m1 = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите число столбцов 3-й матрицы: ");
int l = Convert.ToInt32(Console.ReadLine());
int[,] firstMatrix = new int[n, m];
InputMatrix(firstMatrix);
Console.WriteLine("Первая матрица: ");
PrintMatrix(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = new int[m, l];
InputMatrix(secondMatrix);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(secondMatrix);
Console.WriteLine();
int[,] outputMatrix = new int[n,l];
MultiplicationMatrix(firstMatrix, secondMatrix, outputMatrix);
Console.WriteLine("Результат произведения двух матриц: ");
PrintMatrix(outputMatrix);