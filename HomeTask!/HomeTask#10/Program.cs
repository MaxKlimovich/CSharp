// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает второе число.

int num = new Random().Next(100, 1000);

Console.WriteLine($"случайное число из отрезка 100 - 1000 => {num}");

int NumDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = firstDigit % 10; 
    return firstDigit == secondDigit ? firstDigit : secondDigit;
}

int result = NumDigit(num); 

Console.WriteLine($"второе число {num} => {result}");

