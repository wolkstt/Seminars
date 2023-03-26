// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
int N = 10;
//----------------------------
for (int i = 1; i <= N; i++)
    {
       Console.Write( + i +  ", "); 
    }
//----------------------------
Console.WriteLine(); 
int j = 0;

while (j < N)
    {
       j++;
       Console.Write( + j +  ", "); 
    }
//----------------------------
Console.WriteLine();

j=1;
Console.WriteLine(NatNum(j));

int NatNum(int j)
{
    if (N == j)
    return j;
    else
     Console.Write(NatNum(j+1)+", ");
    return j;
}

*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int m = 0;
int n = 0;

Console.Write("Введите число М': ");
m =  Convert.ToInt32(Console.ReadLine());

Console.Write("ВведитеВведите число N': ");
n =  Convert.ToInt32(Console.ReadLine());

long sum = summa(m,n);
int summa(int m, int n)
 {if (m==n) return n;
  return m+summa(m+1,n);
 }
 Console.WriteLine(sum);
*/
/*  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//

int m = 0;
int n = 0;

Console.Write("Введите число М': ");
m =  Convert.ToInt32(Console.ReadLine());

Console.Write("ВведитеВведите число N': ");
n =  Convert.ToInt32(Console.ReadLine());


int Akk(int m, int n)
{ if (m == 0) return n + 1;
  if (m != 0 && n == 0) return Akk(m - 1, 1);
  if (m > 0 && n > 0) return Akk(m - 1, Akk(m, n - 1));
  return Akk(m,n);
}
Console.Write(Akk(m, n));

