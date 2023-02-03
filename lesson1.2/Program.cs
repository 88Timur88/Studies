// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите первое число:");
bool isParsed = int.TryParse(Console.ReadLine(), out int a);
if(!isParsed)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}

Console.Write("Введите второе число:");
int b = int.Parse(Console.ReadLine());

int sum = b * b;

if(sum == a)
{
    Console.WriteLine("Yes");
}
else
{   
    Console.WriteLine("No");
}
