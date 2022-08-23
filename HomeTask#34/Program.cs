

// Задача 34
// 1. Задайте массив заполненный случайными положительными трехзначными числами.
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.
// Пример:
// [345, 897, 568, 234] → 2


int[] CreatArrRndIn(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

// int[] UsReqArr(int size)
// {
//     int[] newArray = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Введите {i + 1} элемент из {size}: ");
//         newArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return newArray;
// }

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

int CalcArr(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count = count + 1;
    }
    return count;
}


int[] array = CreatArrRndIn(4, 100, 999);
PrintArr(array);

int newArray = CalcArr(array);


Console.WriteLine($" -> ${newArray} ");











