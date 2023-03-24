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

int numberM = 3;
int numberN = 11;
PrintEvenNumbers(numberM, numberN);
