// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble (int size)
{
double[] array = new double[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
array[i] = rnd.NextDouble() * (10 - 1) + 1;
array[i] = Math.Round(array[i], 1);
}
return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double Difference(double[] array)
{
    double diff = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];   
        if (min > array[i]) min = array[i];   
    }
    diff = max - min;
    diff = Math.Round(diff, 1);
    return diff;
}

Console.WriteLine();
double[] arr = CreateArrayRndDouble(10);
PrintArray(arr);
Console.Write(" -> ");
double result = Difference(arr);
Console.WriteLine($"{result}");
