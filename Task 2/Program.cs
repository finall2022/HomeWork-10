/* Задача 2: Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */
Console.Write("Введите число n: ");
string inputn = Console.ReadLine();
int n = int.Parse(inputn);
Console.Write("Введите число m: ");
string inputm = Console.ReadLine();
int m = int.Parse(inputm);

int A(int n, int m)
{
    if (n == 0)
        return m + 1;
    if (n != 0 && m == 0)
        return A(n - 1, 1);
    if (n > 0 && m > 0)
        return A(n - 1, A(n, m - 1));
    return A(n, m);
}
Console.Write(A(n, m));