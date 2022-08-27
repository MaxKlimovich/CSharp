
// Задача 45: 
// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] CreateArrayRndIn(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArr(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    // copy[0] = 2022;   // проверка массива
    return copy;
}

int[] arr = CreateArrayRndIn(4, 0, 8);
PrintArr(arr);
int[] copyArr = CopyArray(arr);
PrintArr(copyArr);
