/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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


/*
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("TRUE - Your number is even");
}
else
{
    Console.WriteLine("FALSE - Your number is odd");
}

*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/
Console.Write("Input pozitive number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 2;

while (current <= number)
{
Console.Write(current + " ");
current += 2;
}
