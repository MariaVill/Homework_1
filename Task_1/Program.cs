// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.WriteLine("Hi, please enetr two numbers:");
int numberA = Int32.Parse(Console.ReadLine());
int numberB = Int32.Parse(Console.ReadLine());
int max=0, min = 0;
if (numberA>numberB)
{
    max = numberA; min = numberB;
}
else
{
    max = numberB; min = numberA;
}
Console.WriteLine($"Number {max} is maximum");
Console.WriteLine($"Number {min} is minimum");

