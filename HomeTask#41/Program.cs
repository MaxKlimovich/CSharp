

// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.
// 0, 7, 6, -2, -4 → 2

Console.Write("Введите элемент(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0) count ++;
}

Console.WriteLine($"Количество чисел больше 0 равно {count} ");