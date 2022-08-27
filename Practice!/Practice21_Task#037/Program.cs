

// Задача 37: 
// 1. Найдите произведение пар чисел в одномерном массиве.
// 2. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// 3. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] arr1 = CreatArrRndIn(6, 0, 10);

int[] resultArr = CalcArrIn(arr1);
PrintArr(arr1);
PrintArr(resultArr);

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

int[] CalcArrIn(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size++;

    int[] resArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        resArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 != 0) resArr[resArr.Length - 1] = arr[size -1]; 
    return resArr;
}