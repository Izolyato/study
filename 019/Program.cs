// Программа принимает на входе девять чисел и выдводит максимальное
Console.WriteLine("Введите девять чисел");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int number4 = Convert.ToInt32(Console.ReadLine());
int number5 = Convert.ToInt32(Console.ReadLine());
int number6 = Convert.ToInt32(Console.ReadLine());
int number7 = Convert.ToInt32(Console.ReadLine());
int number8 = Convert.ToInt32(Console.ReadLine());
int number9 = Convert.ToInt32(Console.ReadLine());
// int max = number1;
// if (max < number2) max = number2;
// if (max < number3) max = number3;
// if (max < number4) max = number4;
// if (max < number5) max = number5;
// if (max < number6) max = number6;
// if (max < number7) max = number7;
// if (max < number8) max = number8;
// if (max < number9) max = number9;
// Console.WriteLine($"Максимальное число --> {max}");

// Вводм мотод Мах
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result<arg2) result = arg2;
    if (result<arg3) result = arg3;
    return result;
}
int max = Max(
    Max(number1,number2,number3),
    Max(number4,number5,number6),
    Max(number7,number8,number9));
    Console.WriteLine($"Максимальное число --> {max}");

