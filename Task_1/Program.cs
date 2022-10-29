// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
int a = -9, b = -3, max = 0, min = 0;
if (a>b)
{
    max = a; min = b;
}
else
{
    max = b; min = a;
}
Console.WriteLine($"{max} большее ");
Console.WriteLine($"{min} меньшее ");

