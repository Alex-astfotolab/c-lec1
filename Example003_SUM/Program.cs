Console.WriteLine("Сложение двух чисел");
Console.WriteLine("Введите первое число:");
string first = Console.ReadLine();
int a = Convert.ToInt32(first);
Console.WriteLine("Введите второе число:");
string second = Console.ReadLine();
int b = Convert.ToInt32(second);
int res = a +b;
Console.WriteLine("Результат: " + res);