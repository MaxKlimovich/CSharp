
int[] array = { 22, 44, 55, 36, 23, 84, 55, 22, 42 };

int n = array.Length; // смотреть по всей длинне массива.
int find = 42;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // означает прерывание.
    }
index++;
}

