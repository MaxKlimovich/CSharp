



// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.



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

            if (j < matrix.GetLength(0) - 1) Console.Write($"{matrix[i, j],4}");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int SumElement(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum += matrix[i, j];
        }
    }
    return sum;
}

int SumElementOneCicle(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

int SumElementTernar(int[,] matrix)
{
    int sum = 0;
    int size = matrix.GetLength(0);
    if(matrix.GetLength(0) > matrix.GetLength(1))  size = matrix.GetLength(1); 
    for (int i = 0; i < size; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

int[,] doublMass = CreateMatrixRndInt(7, 4, 1, 10);
PrintMatrix(doublMass);
Console.WriteLine();
int res = SumElementTernar(doublMass);
Console.WriteLine(res);