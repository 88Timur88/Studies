// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

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

int max = 1;
int min = 0;
int result = 0;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] < max)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
        else i = 0;
    }
    else
    {
        max = array[i];
    }
}
result = max - min;
Console.WriteLine(result);