// 1. По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine() ?? "0");

if(a == b*b)
{
    Console.WriteLine("Да, первое число является квадратом второго");
}
else
{
    Console.WriteLine("Нет, первое число не является квадратом второго ");
}
