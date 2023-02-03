// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число ==>");
bool isParsed = int.TryParse(Console.ReadLine(), out int a);
if(!isParsed)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}
int res = a;
if(a > 99)
{
    while(res >= 999)
        {
            res = res / 10;
        }
        int b = res % 10;
    Console.WriteLine(b);
}
else Console.WriteLine("В заданном числе нет третьей цифры");