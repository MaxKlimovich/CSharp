// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

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

void PrintElem(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(0)) Console.Write($"{matrix[i, j],4}");
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

double SumColons(int[,] matrix, int col)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) { sum = sum + matrix[i, col]; }
    sum = Convert.ToInt32((double)(sum / matrix.GetLength(0)) * 100) / 100.0;
    return sum;
}

Console.WriteLine("Введите кол-во строк a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбиков b: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = CreateMatrixRndInt(a, b, 0, 9);
PrintElem(ourMatrix);

for (int i = 0; i < b; i++) { Console.Write(SumColons(ourMatrix, i) + "; "); }
Console.WriteLine();

