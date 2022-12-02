// Программа которая принимает на вход два числа и 
// выдаёт, какое из них больше какое меньше
Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Первое чило [{number1}] больше второго [{number2}]");
}
else
{
    Console.WriteLine($"Второе чило [{number2}] больше первого [{number1}]");
}