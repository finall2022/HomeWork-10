/* Задача 1: Есть монотонная последовательность,
каждое число встречается ровно то количество раз,
какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,...
Выведите ряд этой последовательности до N-го значения,
желательно использовать рекурсию:
N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5" */
Console.WriteLine("Программа вывода монотонной последовательности до до N-го значения");
Console.WriteLine("Введите значение N: ");
string inputn = Console.ReadLine();
int n = int.Parse(inputn);

void PrintSeq(int n, int k)
{
    var numbers = (k + 1) * k / 2;

    for (int i = numbers - k; i < numbers & i < n; i++)
        Console.Write($"{k}, ");

    if (numbers < n)
        PrintSeq(n, k + 1);
}

PrintSeq(n, 1);
