// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void NewArray(int[]array)
{
    int l = array.Length;
    int index = 0;
    while(index < l)
    {
        array[index] = new Random().Next();
        index++;
    }
}
int [] array = new int [123];
NewArray(array);

Console.WriteLine(string.Join(",",array));

int sum = 0;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 9 & array[i] < 100)
    {
        sum = sum + 1;
    }
}

Console.WriteLine($"В созданном массиве количество чисел из отрезка [10; 99] равно {sum}");