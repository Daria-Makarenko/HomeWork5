// Домашняя работа № 5

// Задача 1 - Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size)
{   
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        //Console.WriteLine($"array[{i + 1}] is {array[i]}");
        Console.Write(array[i] + " ");
    }
}

Console.Write("Input a number elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size);
ShowArray(myArray);

int Quantity(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] %2 ==0)
        {
            count++;
        }
    }
    return count;
}

int number = Quantity(myArray);
Console.WriteLine($"Koli4estvo 4etnix 4isel: {number}");
*/

// Задача 2 - Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        //Console.WriteLine($"array[{i + 1}] is {array[i]}");
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Input a number elements: ");
 int size = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a min possible value: ");
 int min = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a max possible value: ");
 int max = Convert.ToInt32(Console.ReadLine());
 
 int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray); 

int SummaNe4etnix(int[] array)
{
    int sum = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if(i %2 ==1)
           sum = sum + array[i];
    }
    return sum;
}

int result = SummaNe4etnix(myArray);
Console.WriteLine($"Summa ne4etnix 4isel ravna: {result}");
*/

// Задача 3 - Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        //Console.WriteLine($"array[{i + 1}] is {array[i]}");
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Input a number elements: ");
 int size = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a min possible value: ");
 int min = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a max possible value: ");
 int max = Convert.ToInt32(Console.ReadLine());
 
 
 double[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray); 

double MaxMin(double[] array)
{
    double prod = 0;
    double max = array[0];
    double min = array [0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        else min = array[i];
        prod = max - min;
    }
    return prod;
}
double Product = MaxMin(myArray);
Console.WriteLine($"Raznica megdy maksimalnim i minimalnim zna4eniem: {Product}");
*/
