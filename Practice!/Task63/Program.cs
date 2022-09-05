


Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NatureNumber(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NatureNumber(num - 1);

}

NatureNumber(number);