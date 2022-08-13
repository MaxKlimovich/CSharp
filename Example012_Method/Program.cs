                                        // Вид 1 Методы которые ничего не принимают и ничего не возвращают.

// void Method1();
// {
//     Console.WriteLine("Автор ...");
// }
// Method1();

                            // Вид 2 Методы которые могут принимать аргументы, но ничего не возвращают.

// void Method2(string msg);
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");

// void Method21(string msg, int count);
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
//     Method21(msg: "Текст" count: 4);

                                        // Вид 3 Методы которые что-то возвращают но ничего не принимают.

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

                                    // Вид 4 Методы(Функции) которые что-то принимают и что-то возвращают.

// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4(1, "qwerty");
// Console.WriteLine(res);


                                                 // Использование цикла "for" (счетчик который собирает все в одну кучу)

// string Method4(int count, string c)
// {
   
//     string result = String.Empty;

//     for(int i = 0; i < count; i++)
//     {
//         result = result + c;
//     }
//     return result;
// }
// string res = Method4(1, "qwerty");
// Console.WriteLine(res);

                                                //Ипользование цикла в цикле

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

 