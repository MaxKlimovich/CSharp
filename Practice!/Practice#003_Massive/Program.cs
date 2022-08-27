
int num = new Random().Next(10, 100);

Console.WriteLine($"случайное число из отрезка 10 - 99 => {num}");

// int firstDigit = num / 10;
// int secondDigit = num % 10;



// if (secondDigit == firstDigit)
// Console.WriteLine("числа равны");
// else 
// {
//     // int max = fitstDigit;
//     // if (secondDigit > fitstDigit) max = secondDigit;
//     int max = firstDigit > secondDigit ? firstDigit : secondDigit;   

//     Console.Write($"наибольшее количество числа {num} => ");
//     Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);
//     // Console.WriteLine($"наибольшее количество числа {num} => {max}");
// }
    
int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10; 
    if (secondDigit == firstDigit) return -1;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(num); 
string result = maxDigit != -1 ? maxDigit.ToString() : "цифры одинаковые";
Console.WriteLine($"наибольшее количество числа {num} => {result}");
