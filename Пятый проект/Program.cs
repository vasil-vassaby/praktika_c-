Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша") //перевод символов в нижний регистр 
{
    Console.Write("Ура, это же Маша пришла!");
}
else 
{
    Console.Write("Привет, ");
    Console.Write(username);
}