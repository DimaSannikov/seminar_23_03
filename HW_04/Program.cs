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