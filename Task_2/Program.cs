// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a = 22, b = 3, c = 9, max = a;
if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}
else
{
    max = a;
}
Console.WriteLine(max);
