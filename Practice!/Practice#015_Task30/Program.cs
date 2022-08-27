// Напишите программу, которая:
// 1.Выводит массив из 8 элементов заполненный нулями и еденицами в случайном порядке.


// int[] result = FillArray(8, 0, 2);

// PrintArr(result);

// int[] FillArray(int n, int min, int max)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }

// void PrintArr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == 0) Console.Write("[");
//         if (i < array.Length - 1) Console.Write(array[i] + ",");
//         else Console.Write(array[i] + "]");
//     }
// }

                                        // second variant

int[] result = FillArray(8, 0, 2);

PrintArr(result);

int[] FillArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArr(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length -1]);
    Console.Write("]");
}