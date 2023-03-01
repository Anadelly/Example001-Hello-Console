Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Юля")
{
    Console.WriteLine("Ура! Это же ЮЛЯ!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}