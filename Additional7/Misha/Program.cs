void InputMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("Введите символ: ");
            matrix[i, j] = Console.ReadLine()!; 
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
        }
    }
}
void PrintMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}
void NegativeMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == "W" )
                matrix[i, j] = "B";
            else
                matrix[i, j] = "W";

        }
    }
}
int FindErrors(string[,] matrix, string[,] matr)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (matr[i, j] != matrix[i, j])
            {
                count++;
            }
        }
    }
    Console.WriteLine(count);
    return count;
}
Console.Clear();
string[,] matrix = {
    {"W","B","B","W"},
    {"B","B","B","B"},
    {"W","B","B","W"}
};
Console.WriteLine($"{string.Join(" ", matrix.GetLength(0), matrix.GetLength(1))}");
Console.WriteLine("Начальный массив");
PrintMatrix(matrix);
NegativeMatrix(matrix);
string[,] matr =new string[matrix.GetLength(0), matrix.GetLength(1)];
InputMatrix(matr);
Console.WriteLine();
PrintMatrix(matr);
FindErrors(matrix, matr);
