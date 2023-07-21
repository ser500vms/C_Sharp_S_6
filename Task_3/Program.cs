// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Вариант с каждым методом отделно:

// string ConvertToBinary(int number)
// {
//     int[] array = GenerateArrayFromNumber(number);
//     ReverseArray(array);
//     string str = Convert.ToString(array[0]);
//     for (int i = 1; i < array.Length; i++)
//     {
//         str += Convert.ToString(array[i]);
//     }
//     return str;
// }

// void ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int buff = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 -i] = buff;
//     }
// }

// int GenerateArrayFromNumber(int number)
// {
//     int count = 0;
//     int buff = number;
//     while (number > 0)
//     {
//         number /= 2;
//         count++;  
//     }
//     int size = count;
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = buff % 2;
//         buff = buff / 2;
//     }
//     return array;
// }

// Вариант с одним методом:

string GenerateArrayFromNumber(int number)
{
    int count = 0;
    int buff = number;
    while (number > 0)
    {
        number /= 2;
        count++;  
    }
    int size = count;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = buff % 2;
        buff = buff / 2;
    }
    for (int i = 0; i < array.Length / 2; i++)
    {
        buff = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 -i] = buff;
    }
    string str = Convert.ToString(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        str += Convert.ToString(array[i]);
    }
    return str;
}

Console.Write("Введите десятичное число, которое хотите перевести в двоичное: ");
int number = Convert.ToInt32(Console.ReadLine());
string binary = GenerateArrayFromNumber(number);
Console.Write($"{number} -> {binary}");
