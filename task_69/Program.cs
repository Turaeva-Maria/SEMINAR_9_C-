/*
Задача 69: Напишите программу, которая на вход принимает два
числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int Print(int n, int m)
{
   if (m == 0) // цифра
      return 1;
   return Print(n, m - 1) * n;
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Print(n, m));
