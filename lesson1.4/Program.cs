// Найти максимальное из трех чисел

Console.Write("Введите первое целое число:   ");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
if(!isParsedA)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}
Console.Write("Введите второе целое число:   ");
bool isParsedB = int.TryParse(Console.ReadLine(), out int b);
if(!isParsedB)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}
Console.Write("Введите третье целое число:   ");
bool isParsedC = int.TryParse(Console.ReadLine(), out int c);
if(!isParsedC)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}

int max = 0;

if(a > b)
{
    if(a > c) Console.WriteLine("Первое число является самым максимальным");
    else Console.WriteLine("Третье число является максимальным");
}
else
{
    if(b > c) Console.WriteLine("Второе число является максимальным");
    else Console.WriteLine("Третье число является максимальным");
}
