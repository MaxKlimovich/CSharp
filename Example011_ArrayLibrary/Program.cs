void FillArray(int[] collection)
{
    int lenght = collection.Length; // длинна нашего массива.
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
// void метод означает что этот метод ничего не возвращает. Поэтому значение return не работает при методе Void.

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создай новый массив в котором будет 10 элементов он будет 
                           // заполнен нулями и нужно заполнить его своими элементами.

FillArray(array);
array [6] = 5; //мы принудительно ставим любые значения где угодно. В данном примере поставили на [6] индексе

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 5);
Console.WriteLine(pos);
