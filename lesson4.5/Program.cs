// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
//  второй и предпоследний и т.д.

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
int [] array = new int [7];
NewArray(array);

Console.WriteLine(string.Join(",",array));
Console.WriteLine();

int sum = 0;
int sum1 = 0;
int sum2 = 0;
int i2 = 0;

for(int i = 0; i < array.Length; i++)
{
    i2 = array.Length -1;
    while(i < array.Length / 2)
    {
        sum1 = sum1 + array[i];
        sum2 = sum2 +array[i2];
        sum = sum1 + sum2;
        Console.WriteLine(sum);
        i++;
        i2 = i2 - 1;
        sum1 = 0;
        sum2 = 0;
    }
}

Console.WriteLine($"Сумма четных чисел равна {sum1}");
