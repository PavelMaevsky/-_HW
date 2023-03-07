/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine($"max is first number: {a}");
    Console.WriteLine($"min is second number: {b}");
}
else
{
    if(a == b)
    {
        Console.Write("The numbers are equal");
    }
    else
    {
        Console.WriteLine($"max is second number: {b}");
        Console.WriteLine($"min is first number: {a}");
    }
}
*/

/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c )
{
    Console.Write($"maximum number is: {a}");
}
else
{ 
    if (b >= a && b > c )
    {
        Console.Write($"maximum number is: {b}");
    }
    else 
    { 
        Console.Write($"maximum number is: {c}");
    }
}
*/