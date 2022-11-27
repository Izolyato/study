// Если ты Cаша = тебе большой привет иначе пока (if/else)
Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if(username.ToLower() == "саша")
{
Console.WriteLine("Приветствую вас, Александр");
}
else
{
    Console.Write ("Пока  ");
    Console.WriteLine (username);
}