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