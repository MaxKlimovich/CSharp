
Console.WriteLine("введите число от 1 до 7 ");
int num = Convert.ToInt32(Console.ReadLine());
string day = "";
if (num >= 1 && num <= 7)
{
    switch(num)
    {
        case 1:
            day = "Понедельник";
            break;
        case 2:
            day = "Вторник";
            break;
        case 3:
            day = "Среда";
            break;
        case 4:
            day = "Четверг";
            break;
        case 5:
            day = "Пятница";
            break;
        case 6:
            day = "Суббота";
            break;
        case 7:
            day = "Воскресение";
            break;
    }
    Console.WriteLine("День недели: " +day);
}
else
{
    Console.WriteLine("Вы ввели не корректное число");
}