// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[10];  
FillArray(array);
PrintArray(array); 
Console.WriteLine();
Console.WriteLine($"Сумма значений нечётных элементов в массиве равна {SumOdd(array)}");

int SumOdd(int[] array)
{
    int sum = 0;
    int i;
    for(i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

void FillArray(int[] array)
{
    int length = array.Length; 
    int index = 0; 
    while(index < length)
    {
        array[index] = new Random().Next(-90,90); 
        index++; 
    }
}

void PrintArray(int[] array)
{
    int length = array.Length; 
    int index = 0; 
    while(index < length)
    {
        Console.Write($"{array[index]}, ");  
        index++;      
    }
}
