
// Задача 32.
// Написать программу.
// 1. Заменить эллементы массива.
// 2. Заменить на соответствующие отрицательные.
// 3. Заменить на соответствующие положительные.

// [-4, -8, 8, 2] => [4, 8, -8, -2]


int[] CteatArrayIn(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

int[] EspandiArr(int[] array)
{
    int Neg = 0;
    int Pos = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
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
int[] arr = CteatArrayIn(18, -9, 9);
PrintArr(arr);
Console.WriteLine();
int[] neg = EspandiArr(arr);
PrintArr(neg);