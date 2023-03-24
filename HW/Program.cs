// Задайте значение N. Напишите программу, которая выведет все
// четные натуральные числа в промежутке от m до N . Выполнить
// с помощью рекурсии.
// M, N = 5, 8 -> "6, 8"
// M, N = 2, 4 -> "2, 4"

void PrintEvenNumbers(int leftRange, int rightRange)
{
    if (rightRange < leftRange)
    {
        return;
    }

    if (leftRange % 2 == 0)
    {
        Console.Write($"{leftRange} ");
        leftRange += 2;
    }
    else
    {
        leftRange++;
    }
    PrintEvenNumbers(leftRange, rightRange);
}

int numberM = 10;
int numberN = 16;
PrintEvenNumbers(numberM, numberN);


// Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int PrintSumNumbers(int leftRange, int rightRange)
{
    if (rightRange < leftRange)
    {
        return 0;
    }
    return PrintSumNumbers(leftRange + 1, rightRange) + leftRange;

}

int numberM = 2;
int numberN = 6;
int sum = PrintSumNumbers(numberM, numberN);
Console.WriteLine(sum);


// Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReturnAckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (m > 0 && n == 0)
    {
        return ReturnAckermannFunction(m - 1, 1);
    }

    if (m > 0 && n > 0)
    {
        return ReturnAckermannFunction(m - 1, ReturnAckermannFunction(m, n-1));
    }
    
    return n;
    
}

Console.WriteLine(ReturnAckermannFunction(3, 2));


// Задача со звездочкой Найти второй максимум в массиве.
// 4, 4, 3, 0, 2 => 3

int[] MakeArray(int len = 10, int max = 10)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("["+$"{String.Join(", ", array)}"+"]");
}

int FindSecondMax(int[] array)
{
    int max = 0;
    int secondMax = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            secondMax = max;
            max = array[i];
        }
        else
        {
            if (array[i] > secondMax && array[i] < max) secondMax = array[i];
        }
    }
    
    return secondMax;
}

int[] array = MakeArray(10, 20);
PrintArray(array);
Console.WriteLine(FindSecondMax(array));