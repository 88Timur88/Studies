// Задать массив, заполнить случайными положительными трёхзначными числами.
//  Показать количество нечетных\четных чисел


void NewArray(int[]array)
{
    int l = array.Length;
    int index = 0;
    while(index < l)
    {
        array[index] = new Random().Next(100, 1000);
        index++;
    }
}
int [] array = new int [8];
NewArray(array);

// void PrintArray(int[]array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//     }
// }
// PrintArray(array);
Console.WriteLine(string.Join(",",array));
Console.WriteLine();

int sum = 0;
int sum1 = 0;
int sum2 = 0;

for(int i = 0; i < array.Length; i++)
{
    sum = array[i] % 2;
    if(sum == 0)
    {
        sum1 = sum1 + array[i];
    }
    else
    {
        sum2 = sum2 + array[i];
    }
}

Console.WriteLine($"Сумма четных чисел равна {sum1}");
Console.WriteLine($"Сумма нечетных чисел равна {sum2}");