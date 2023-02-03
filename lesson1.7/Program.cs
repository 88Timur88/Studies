// Показать последнюю цифру трёхзначного числа

Console.Write("Введите число ==>");
bool isParsed = int.TryParse(Console.ReadLine(), out int a);
if(!isParsed)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}

if(a > 99 && a < 1000)
{
    int b = a % 10;
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
