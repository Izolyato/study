// Принимаем на входе трёхзначное число на выходе получаем последнюю цифру числа.
Console.WriteLine("Введите тёхзначное число");
int number = Convert.ToInt32 (Console.ReadLine());
int lastnum = 0;
if  ( number < 0 )
{
    number = number * -1;
}
if (number < 999 && number > 99 )
{
    lastnum = number%10;
    Console.WriteLine($"Последняя цифра {lastnum}");
}
else Console.WriteLine("Число не трёхзначное");