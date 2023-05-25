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
Console.Write("Количество четных чисел: ");
int count=0;
for(int i=0; i<8; i++)
{
    if(array[i]%2==0)
    {
        count++;
    }
}
Console.Write(count);
