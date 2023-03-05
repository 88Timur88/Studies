// Найти сумму элементов от M до N, N и M заданы

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

int sum = 0;
while(n <= m)
{
    sum = sum + m;
    m = m - 1;
}

Console.Write($"{sum}");