﻿/* Задача 1: Есть монотонная последовательность, 
каждое число встречается ровно то количество раз, 
какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... 
Выведите ряд этой последовательности до N-го значения, 
желательно использовать рекурсию:
N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5" */
Console.WriteLine("Программа вывода монотонной последовательности до до N-го значения");
Console.WriteLine("Введите значение N: ");
string inputn = Console.ReadLine();
int n = int.Parse(inputn);
int[] arr = new int[n];

int Sequence(int nTemp, int iTemp)
{

    if (iTemp == nTemp) return nTemp;
    return Sequence(nTemp - 1, iTemp);
}
int i = 1;
Console.Write(Sequence(n, i));
