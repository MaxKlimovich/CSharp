// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


Console.WriteLine("введите первое число ");
int firstNum = Convert.ToInt32(Console.ReadLine());


bool CheckNum(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

bool result = CheckNum(firstNum);

Console.WriteLine(result ? "yes" : "no");
