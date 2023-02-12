// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);
int res = 2;

while (res <= number)
{
    if (res % 2 == 0)
    {
        Console.Write(res + (" "));
    }
    res++;
}
