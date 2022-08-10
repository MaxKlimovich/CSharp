

int MaxDigit(int num)
{
    int firstDigit = num / 100;
    int tindlyDigit = num % 10;
    int result = firstDigit * 10 + tindlyDigit;
    return result;
}

int number = new Random().Next(100, 1000);


int res = MaxDigit(number); 
Console.WriteLine($"Сгенерированное число {number} => {res}");