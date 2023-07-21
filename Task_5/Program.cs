// Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.


int[] ArrayCopy(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for (int i = 0; i < arrayCopy.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}


int[] GenerateRandomArray(int size, int start, int finish)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, finish + 1);
    }
    return array;
}


int[] array = GenerateRandomArray(5, 1, 9);
Console.Write($"[{String.Join(", ", array)}] -> ");
int[] copyArray = ArrayCopy(array);
Console.Write($"[{String.Join(", ", copyArray)}]");