// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] Function(int[] array)
{
    for(int i=0; i<8; i++)
    {
        array[i]=new Random().Next(100,1000);
    }
    return array;
}

int[] array=new int[8];
array=Function(array);
Console.Write("Значения массива: ");
for(int i=0; i<8; i++)
{
    Console.Write(array[i]+" ");
}
Console.WriteLine("");
Console.Write("Сумма элементов, стоящих на нечётных позициях = ");
int sum=0;
for(int i=1; i<8; i+=2)
{
    sum+=array[i];
}
Console.Write(sum);
