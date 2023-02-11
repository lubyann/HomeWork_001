//Напишите программу
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Enter a numberA: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Enter a numberB: ");
int numberB = int.Parse(Console.ReadLine()!);
Console.Write("Enter a numberC: ");
int numberC = int.Parse(Console.ReadLine()!);

if(numberA > numberB && numberA > numberC)
{
    Console.WriteLine("Max = " + numberA);
}
if(numberB > numberA && numberB > numberC)
{
    Console.WriteLine("Max = " + numberB);
}
if(numberC > numberA && numberC > numberB)
{
    Console.WriteLine("Max = " + numberC);
}

