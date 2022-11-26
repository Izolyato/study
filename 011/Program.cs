// Дни недели по запросу
Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32 (Console.ReadLine());
if (day == 1) Console.WriteLine("Понедельник");
if (day == 2) Console.WriteLine("Вторник");
if (day == 3) Console.WriteLine("Среда");
if (day == 4) Console.WriteLine("Четверг");
if (day == 5) Console.WriteLine("Пятница");
if (day == 6) Console.WriteLine("Субота");
if (day == 7) Console.WriteLine("Воскресенье");
else if (day > 8 || day < 1) Console.WriteLine("Введённый номер вне диапозона");