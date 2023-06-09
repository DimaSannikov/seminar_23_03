﻿// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int MyPower(int number, int exp)
{
    if (exp == 0) return 1;
    return number * MyPower(number, exp - 1);
}

Console.WriteLine(MyPower(3, 5));