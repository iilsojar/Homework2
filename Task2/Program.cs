//По двум заданным числам проверять является ли одно квадратом другого

Console.Clear();
Console.WriteLine("введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA == numberB * numberB)
    Console.WriteLine ($"число {numberA} является квадратом числа {numberB}");
else
{
    Console.WriteLine ($"число {numberA} не является квадратом числа {numberB}");
}
if (numberB == numberA * numberA)
Console.WriteLine ($"число {numberB} является квадратом числа {numberA}");
else
{
    Console.WriteLine ($"число {numberB} не является квадратом числа {numberA}");
}