
Console.WriteLine("введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int sqrt = (number % 2);

if (sqrt == 0)
{
    Console.WriteLine($"Число {number} является четным числом ");
}
else 
{
    Console.WriteLine($"Число {number} является не четным числом ");
}

