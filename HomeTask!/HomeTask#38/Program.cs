

// Задача 38
// 1. Задайте массив вещественных чисел
// 2. Найдите разницу между максимальным и минимальным элементом массива.

// [3.5, 17.2, 2.1] → 19.3


double[] CreateArrayRndDouble (int size, double min, double max)
{
	double[] array = new double[size];
	Random rnd = new Random();
	
	for (int i = 0; i < size; i++)
	{
		array[i] = Math.Round((rnd.NextDouble()*(max - min) + min), 2);
	}
	return array;
}

double FindMax (double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double FindMin (double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double[] doubleArray = CreateArrayRndDouble(7, 10.0, 100.0);
Console.WriteLine("[{0}]", string.Join(", ", doubleArray));
double max = FindMax(doubleArray);
double min = FindMin(doubleArray);
Console.WriteLine($"Минимальное значение в массиве = {min}");
Console.WriteLine($"Максимальное значение в массиве = {max}");
Console.WriteLine($"Разница между минимальным и максимальным = {max - min}");