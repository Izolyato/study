// Программа которая выводит случайное число из отрезка от 10 до 99
//и показывает наибольшую цифру числа
//Console.WriteLine("Hello, World!");
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 --> {number}");
int num1 = number / 10;
int num2 = number % 10;
if (num1 > num2)
{
    Console.WriteLine($"Наибольная цифра числа {number} --> {num1}");
}
else
{
    Console.WriteLine($"Наибольная цифра числа {number} --> {num2}");
}