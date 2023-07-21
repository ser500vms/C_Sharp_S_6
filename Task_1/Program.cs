// Задача 39: 
// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int buff = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 -i] = buff;
    }
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

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = GenerateRandomArray(size, 1, 9);
Console.Write($"[{String.Join(", ", array)}] -> ");
ReverseArray(array);
Console.Write($"[{String.Join(", ", array)}]");