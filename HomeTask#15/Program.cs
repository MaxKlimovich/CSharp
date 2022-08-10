
Console.WriteLine("введите число от 1 до 7 ");
int num = Convert.ToInt32(Console.ReadLine());
string day = "";
if (num >= 1 && num <= 7)
{
    switch(num)
    {
        case 1:
            day = "№1 Понедельник не выходной";
            break;
        case 2:
            day = "№2 Вторник не выходной";
            break;
        case 3:
            day = "№3 Среда не выходной";
            break;
        case 4:
            day = "№4 Четверг не выходной";
            break;
        case 5:
            day = "№5 Пятница не выходной";
            break;
        case 6:
            day = "№6 Суббота выходной";
            break;
        case 7:
            day = "№7 Воскресение выходной";
            break;
    }
    Console.WriteLine("День недели: " +day);
}
else
{
    Console.WriteLine("Вы ввели не корректное число");
}

