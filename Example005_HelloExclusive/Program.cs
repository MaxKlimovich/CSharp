Console.WriteLine("Введите ваше имя");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.Write("О, это же Маша!");
}
else 
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}