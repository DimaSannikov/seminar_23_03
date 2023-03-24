// Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

bool IsPrime(int number, int divider = 0)
{
    if (divider == 0) divider = number / 2;
    if (divider == 1) return true;
    return number % divider != 0 && IsPrime(number, divider - 1);
}

Console.WriteLine(IsPrime(11));