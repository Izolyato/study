// Программа которая принимает на вход три числа и вадаёт,
// Какое из этих чимел максимальное.
Console.WriteLine("Введите три числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"Первое чило [{number1}] максимальное");
}
if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"Второе  чило [{number2}] максимальное");
}
if (number3 > number1 && number3 > number2)
{
    Console.WriteLine($"Третье чило [{number3}] максимальное");
}

