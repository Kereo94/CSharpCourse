Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("УРААА, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}