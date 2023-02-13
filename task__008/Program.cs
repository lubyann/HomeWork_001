// // Напишите программу, которая на вход принимает число (N), 
// // а на выходе показывает все чётные числа от 1 до N.
// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

//Первое решение на сдачу

// Console.Write("Enter a number: ");
// int number = int.Parse(Console.ReadLine()!);
// int res = 2;

// while (res <= number)
// {
//     if (res % 2 == 0)
//     {
//         Console.Write(res + (" "));
//     }
//     res++;
// }

// Вывод чисел через запятую
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);

void FillArray(int[] collection)
{
    number = collection.Length;
    collection[0] = 1;
    int index = 1;
    while (index < number)
    {

        collection[index] = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {

        position++;

    }
}
int[] array = new int[number];
FillArray(array);
PrintArray(array);
//Console.Write(string.Join(", ",array.Select(x =>x.ToString())));
int[] evenArr = array.Where(x => x % 2 == 0).ToArray();
Console.WriteLine(string.Join(", ", evenArr.Select(x => x.ToString())));
