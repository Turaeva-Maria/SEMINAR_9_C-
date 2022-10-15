/*
Задача 67: Напишите программу, которая будет принимать на вход
число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int Print(int n)
{
   if (n < 10) // цифра
      return n;
   return Print(n / 10) + n % 10;
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Print(n));

