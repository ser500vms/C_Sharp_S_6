// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// Последовательность чисел Фибоначчи Fn = F(n-1) + F(n-2),

// Мое решение: 

// void Fibonacci(int n)
// {
//     if (n <= 0)
//     {
//         Console.Write(" 0 ");
//     }
//     else
//     {
//         Console.Write("0, 1, ");
//     }
//     long a = 0;
//     long b = 1;
//     int count = n;

//     for (int i = 3; i <= n; i++)
//     {
//         long temp = a + b;
//         a = b;
//         b = temp;
//         Console.Write($"{b}, ");
//     }
//     count--;
// }

// Fibonacci(5);
// int n = 5;
// long fib = Fibonacci(n);
// Console.WriteLine("n-е число Фибоначчи при n=" + n + " равно " + fib);

// Решение на семинаре:
// void DoFibonachi (int number)
// {
//     Console.Write ("Если N " + number + " -> 0 1")
//     int number1 = 0;
//     int number2 = 1;
//     for (int i = 0; i < number; i++)
//     {
//         int number3 = number1 + number2;
//         number1 = number2;
//         number2 = number1;
//         Console.Write(" " + number3)
//     }
// }

// int GetInput (string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int number = GetInput("Введите число: ");
// DoFibonachi(number);







