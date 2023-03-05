// Показать натуральные числа от M до N, N и M заданы
Console.Write("Введите первое натуральное число M  = ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
if(!isParsedM)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}

Console.Write("Введите второе целое число N  = ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if(!isParsedN)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}

while(n <= m)
{
    Console.Write($"{m} ");
    m = m - 1;
}