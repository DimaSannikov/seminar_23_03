// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int SumNumber(int num)
{
    if (num == 0) return 0;
    
    return num % 10 + SumNumber(num/10);
}

Console.WriteLine(SumNumber(450));