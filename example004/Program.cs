// 4. Выяснить является ли число чётным

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine() ?? "0");

if (a % 2 == 1)
{
    Console.WriteLine("Число не является четным");
}
else
{
    Console.WriteLine("число является четным");
}

