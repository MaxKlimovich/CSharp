

// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


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

void PrintArr(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

void PrintMatrixiu(int[,] array)
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

int[,] ConvertMatrix2Array(int[,] matrix);
{
    int[] result = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[count] = CreateMatrixRndInt[i, j];
            count++;
        }
    }
    Array.Sort(result);
    return result;
}

void CountSimularElem(int[] array);
{
    int count = 0;
    int number = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == i) count ++;
        else 
        {
            Console.WriteLine($"{number} -> {count}");
            number = array[i];
            count = 0;

        }
    }
}

int[,] array = CreateMatrixRndInt(3, 5, 10, 99);
PrintElem(array);

Console.WriteLine();
int[,] newArr = ConvertMatrix2Array(array);
PrintElem(newArr);

Console.WriteLine();
CountSimularElem(newArr);