// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
// Определить, присутствует ли в заданном массиве, некоторое число

void NewArray(int[]array)
{
    int l = array.Length;
    int index = 0;
    while(index < l)
    {
        array[index] = new Random().Next(0, 2);
        index++;
    }
}
int [] array = new int [8];
NewArray(array);

Console.Write("Введите число для поиска в массиве:::>  ");
bool isParsed = int.TryParse(Console.ReadLine(), out int num);
if(!isParsed)
{
    Console.WriteLine($"Введённое значени не соответствует требованиям!!!");
    return;
}

void PrintArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}

PrintArray(array);

Console.WriteLine();

for(int i = 0; i < array.Length; i++)
{
    if(num == array[i])
    {
        Console.Write("yes   ");
    }
    else
    {
        Console.Write("no   ");
    }
}