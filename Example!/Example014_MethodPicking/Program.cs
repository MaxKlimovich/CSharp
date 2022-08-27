
int[] arr = { 2, 5, 3, 4, 1, 6, 8, 7 };

void PrintArray(int[] array)
{
    int count = array.Length;
    
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSearch(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporrary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporrary;
    }
}

PrintArray(arr);
SelectionSearch(arr);

PrintArray(arr);

