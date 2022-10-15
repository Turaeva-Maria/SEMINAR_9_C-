/*
Задача 68: Напишите программу вычисления функции Аккермана с
помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

string Print(int m, int n)
{
   if (n == m)
      return $"{n} ";
   return Print(m, n - 1) + $"{n} ";
}

int FunctionAkkerman(int numbm, int numbn)
{
    if (numbm == 0)
    {
        return numbn + 1;
    }
    if (numbm > 0 && numbn == 0)
    {
        return FunctionAkkerman(numbm - 1, 1);
    }
    else
    {
        return FunctionAkkerman(numbm - 1, FunctionAkkerman(numbm, numbn - 1));
    }
}

Console.Clear();
Console.Write("Введите 1-ое число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m >=0 && n >=0) 
{
    int sum = FunctionAkkerman(n, m);
    Console.WriteLine($"Результат функции Аккермана: {sum}");
}
else
{
    Console.WriteLine($"Ошибка ввода: числа m ({m}) и n ({n}) не могут быть отрицательными");
}





