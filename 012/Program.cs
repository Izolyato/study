// Все числа от N до -N
Console.WriteLine("Введите чило");
int n = Convert.ToInt32 (Console.ReadLine());
int nminus = 0;
if (n < 0)
{
    n = -n;
    nminus = -n;
}
else nminus = -n;

while (nminus <= n)
{
    Console.Write($"{nminus} ");
    nminus++;
}
