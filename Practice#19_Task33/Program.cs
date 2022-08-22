

// Задача 33: Задайте массив. 
// 1.Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int[] CreatArrayIn(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
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

bool FindElemInArray(int[] array, int elemf)
{
    bool ret = false;
    for (int i = 0; i < array.Length; i++)
    {
            if (array[i] == elemf) ret = true;
            {
                ret = true;
                break;
            }
    }
    return ret;
}

Console.WriteLine("Введите число");
int findI = Convert.ToInt32(Console.ReadLine());
int[] arr = CreatArrayIn(12, -9, 9);
PrintArr(arr);
bool search = FindElemInArray(arr, findI);

Console.WriteLine(search ? $"Число {findI} в массиве присутствует" : $"Число {findI} в массиве отсутствует");

