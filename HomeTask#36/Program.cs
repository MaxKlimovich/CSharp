

// Задача 36
// 1. Задайте одномерный массив заполненный случайными числами
// 2. Найдите сумму элементов стоящих на не четных позициях


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

int CalcArr(int[] array)
{
    int count = 0; 
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    
    if (i % 2 != 0) 
        sum = sum + array[i];
    
    return sum;
}


int[] array = CreatArrRndIn(4, 0, 100);
PrintArr(array);

int newArray = CalcArr(array);


Console.WriteLine($" -> {newArray} ");