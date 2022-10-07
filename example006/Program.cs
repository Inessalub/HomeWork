// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите трехзначное  число ");
int a = int.Parse(Console.ReadLine() ?? "0");

int Number(int b)
{
    return b % 10;
}
Console.WriteLine("Последняя цифра " + Number(a));
