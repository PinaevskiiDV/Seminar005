double[] array = new double[10];  
FillArray(array);
PrintArray(array); 
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {MaxElement(array) - MinElement(array)}");

double MaxElement(double[] array)
{
    double max = 0;
    int i;
    for(i = 0; i < array.Length; i++)
    {
        if(max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double MinElement(double[] array)
{
    int i = 0;
    double min = array[i];
    for(; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

void FillArray(double[] array)
{
    int length = array.Length; 
    int index = 0; 
    while(index < length)
    {
        array[index] = new Random().Next(0, 100); 
        index++; 
    }
}

void PrintArray(double[] array)
{
    int length = array.Length; 
    int index = 0; 
    while(index < length)
    {
        Console.Write($"{array[index]}, ");  
        index++;      
    }
}

