// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int FindMax(int[] array)
{
    int max=0;
    for(int i=0; i<5; i++)
    {
        if(array[i]>max)
        {
            max=array[i];
        }
    }
    return max;
}
int FindMin(int[] array)
{
    int min=10000;
    for(int i=0; i<5; i++)
    {
        if(array[i]<min)
        {
            min=array[i];
        }
    }
    return min;
}
int[] array={3, 7, 22, 2, 78};
int min=FindMin(array);
int max=FindMax(array);
Console.Write(max-min);
