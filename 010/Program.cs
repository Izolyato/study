// Проверка является ли число квадратом второго
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int kvadrat1 = num1 * num1;
//int kvadrat2 = num2*num2;
if (kvadrat1 == num2)
{
    Console.WriteLine($"Является квадратом ");

}
else
{
    Console.WriteLine($"Не является квадратом");
}
