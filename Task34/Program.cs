// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[100];  
FillArray(array);
PrintArray(array); 
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве {FindPositive(array)}");

int FindPositive(int[] array)
{
    int count = 0;
    int i;
    for(i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        count++;
    }
    return count;
}

void FillArray(int[] array)
{
    int length = array.Length; 
    int index = 0; 
    while(index < length)
    {
        array[index] = new Random().Next(100,1000); 
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
