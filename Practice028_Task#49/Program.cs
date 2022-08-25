

// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)   // matrix.GetLength(0)
    {
        for (int j = 0; j < col; j++)  // matrix.GetLength(1)
        {
            matrix[i, j] = rnd.Next(min, max + 1);

        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            if (j < matrix.GetLength(0) -1) Console.Write($"{matrix[i,j], 4}");
            else Console.Write($"{matrix[i,j], 4}");
        }
        Console.WriteLine("]");
    }
}

int[,] ToSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
        }
    }
    return matrix;
}

int[,] matrix = CreateMatrixRndInt(1,4,0,10);
PrintMatrix(matrix);
Console.WriteLine();
int[,] toSquare = ToSquare(matrix);
PrintMatrix(toSquare);