// Задача 40: Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.


void Triangle(int num1, int num2, int num3)
{
    if (num1 < num2 + num3)
    {
        if (num2 < num1 + num3)
        {
            if (num3 < num2 + num1)
            {
               Console.WriteLine("Треугольник существует ");     
            }
            else
            {
                Console.WriteLine("Треугольник не существует ");   
            }
        }
        else
        {
            Console.WriteLine("Треугольник не существует ");   
        }
    }
    else
    {
        Console.WriteLine("Треугольник не существует ");   
    }
}



Console.WriteLine("Введите 1-е число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Triangle(num1, num2, num3);