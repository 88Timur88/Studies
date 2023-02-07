// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите число дня недели: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if(!isParsed)
{
    Console.WriteLine("Введено неправильное значение");
}

int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;

if(number > 0 && number < 8)
{
    if(number == a) Console.WriteLine("no");
    if(number == b) Console.WriteLine("no");
    if(number == c) Console.WriteLine("no");
    if(number == d) Console.WriteLine("no");
    if(number == e) Console.WriteLine("no");
    if(number == f) Console.WriteLine("yes");
    if(number == g) Console.WriteLine("yes");
}
else
{
    Console.WriteLine("Ввведенное значение не является числом недели");
}