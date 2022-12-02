// Программа которая принимает на вход число N и выводит все чётные числа от 1 до N
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= n)
{
    Console.Write($"{count} ");
    count = count + 2;
}
