// Выяснить, кратно ли число заданному, если нет, вывести остаток.

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
    int remainder = a % b;
    Console.WriteLine($"Остаток от деления первого числа на второе равен {remainder}");
}