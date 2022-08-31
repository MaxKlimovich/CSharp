


// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintElem(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (j < array.GetLength(0) - 1) Console.Write($"{array[i, j],4}");
            else Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

void SwapRowToCol(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = i + 1; j < col; j++)
        {
            int copy = matrix[i,j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = copy;
        }
    }
    
}

bool SqMatr(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}


int[,] array = CreateMatrixRndInt(5, 5, 10, 99);
PrintElem(array);
if (SqMatr(array))
{
    SwapRowToCol(array);
    Console.WriteLine();
    PrintElem(array);
}
else 
{
    Console.WriteLine("Невозможно заменить");
}
