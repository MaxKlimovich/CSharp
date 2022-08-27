
// Задача 47. 
// Задайте двумерный массив размером m*n.
// Заполнить его случайными вещественными числами.



double[,] CreateMatrixRnddouble(int m, int n)
{
    double[,] matrix = new double[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)   
    {
        for (int j = 0; j < n; j++)  
            matrix[i, j] = Math.Round((rnd.NextDouble() *100), 1); 
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(0) - 1) Console.Write($"{matrix[i, j], 6}");
            else Console.Write($"{matrix[i, j], 6}");
        }
        Console.WriteLine("]");
    }
}

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] doublMass = CreateMatrixRnddouble(m, n);
PrintMatrix(doublMass);

