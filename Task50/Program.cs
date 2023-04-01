void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = i + j;
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
void ReviewPosition(int[,] matrix, int[] position)
{
if(position[0] <= matrix.GetLength(0)
&& position[1] <= matrix.GetLength(1) 
&& position[0] > 0 
&& position[1] > 0) 
{
  int result = matrix[position[0]-1, position[1]-1];
  Console.Write($"Значение элемента: {result}");
}
else Console.Write($"Такой позиции элемента в массиве нет");
}
Console.Clear();
int[,] matrix = new int[4, 4];
InputMatrix(matrix);
Console.WriteLine("Массив");
PrintMatrix(matrix);
Console.Write("Введите позицию элемента: ");
int[] position = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
ReviewPosition(matrix, position);