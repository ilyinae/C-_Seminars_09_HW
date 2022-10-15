// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

double AkkermanFunction(double i, double j)
{
    if (i == 0)
        return j + 1;
    else
        if (j == 0)
        return AkkermanFunction(i - 1, 1);
    else
    {
        if (i > 0 && j > 0)
            return AkkermanFunction(i - 1, AkkermanFunction(i, j - 1));
        else
            return double.MinValue;
    }
}
Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Convert.ToString(AkkermanFunction(m, n)));