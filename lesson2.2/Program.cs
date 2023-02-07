// По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите первое число:::>");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
if(!isParsedA)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}
Console.Write("Введите второе число:::> ");
bool isParsedB = int.TryParse(Console.ReadLine(), out int b);
if(!isParsedB)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}

int sum = a % b;
if( sum == 0) Console.WriteLine("Первое число кратно второму");
else
{
    Console.WriteLine("Первое число не кратно второму");
}