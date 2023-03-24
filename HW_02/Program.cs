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