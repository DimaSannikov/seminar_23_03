// Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

bool MultipleOfTwo(int num)
{
    if (num / 2 == 1) return true;
    if (num % 2 == 1) return false;
    return MultipleOfTwo(num / 2);
}

Console.WriteLine(MultipleOfTwo(16));