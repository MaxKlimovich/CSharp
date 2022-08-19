// Задача 31: 
// 1. Задайте массив из 12 элементов. 
// 2. Заполненный случайными числами из промежутка [-9, 9]. 
// 3. Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.




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

int[] GetSumPosNegElem(int[] array)
{
    int sumNeg = 0;
    int sumPos = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            sumNeg += array[i];
        else
            sumPos += array[i];
    }
    return new int[] { sumNeg, sumPos };

    // int[] arr = new int[] { sumNeg, sumPos};
    // return arr;

    // int[] array = new int[2];
    // arr[0] = sumNe;
    // arr[1] = sumPos;
    // return arr;
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

int[] arr = CreateArrayRndIn(12, -9, 9);
PrintArr(arr);

int[] sumPosNegElem = GetSumPosNegElem(arr);
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных цифр равна {sumPosNegElem[0]}");
Console.WriteLine($"Сумма положительных цифр равна {sumPosNegElem[1]}");