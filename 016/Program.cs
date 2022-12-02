// Программа которая принимает на вход одно число и проверяет является ли оно чётным
// (делится ли оно на два без остатка)
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("чётное");
}
else
{
    Console.WriteLine("не чётное");
}