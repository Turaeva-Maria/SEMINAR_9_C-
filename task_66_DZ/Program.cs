/* 
Задача 66: Задайте значения M и N. Напишите программу, которая
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

string Print(int m, int n)
{
   if (n == m)
      return $"{n} ";
   return Print(m, n - 1) + $"{n} ";
}

int SumCount(int numberN, int numberM)
{
    if (numberN < numberM) return 0;
    int summa = SumCount(numberN - 1, numberM);
    return summa += numberN;
}

Console.Clear();
Console.Write("Введите 1-ое число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n) 
Console.WriteLine($"Ошибка ввода: значение числа M = {m} больше числа N = {n}");

else
{
    Console.Write($"Сумма чисел {Print(m, n)} = ");
    int summa = SumCount(n, m);
    Console.WriteLine(summa);
}




