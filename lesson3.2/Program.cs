// Подсчитать сумму цифр в числе

Console.Write("Введите число:   ");
bool isParsed = int.TryParse(Console.ReadLine(), out int a);

if(!isParsed)
{
    Console.WriteLine("Введено неправильное значение");
    return;
}

int result = 0;
int sum;
while(a != 0)
{
    sum = a % 10;
    a = a / 10;
    result = result + sum;    
}
Console.WriteLine(result);
