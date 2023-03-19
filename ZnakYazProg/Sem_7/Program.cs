/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int m = 0;
int n = 0;

while(1 >= m && 1 >= n) 
{
Console.Write("Введите количество строк массива': ");
m =  Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива': ");
n =  Convert.ToInt32(Console.ReadLine());
}
    
    double[,] array = new double[m,n]; 

    void ShowArray(double[,] array)
{
        for(int i = 0; i < m; i++)
        {
        for(int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(-10,10);
            Console.Write(array[i,j] + "     ");
        }
            Console.WriteLine();
        
        }
}
ShowArray(array);
*/
//--------------------------------------------------------------------------------------------------

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//

int m = 0;
int n = 0;
int[,] array = new int[10,10];
     
    void ShowArray(int[,] array)
{
        for(int i = 0; i < 10; i++)
        {
        for(int j = 0; j < 10; j++)
        {
            array[i,j] = new Random().Next(-10,10);
            Console.Write(array[i,j] + "     ");
        }
            Console.WriteLine();
        
        }
}
ShowArray(array);

while(0 >= m && 0 >= n) 
{
Console.Write("Введите строку массива': ");
m =  Convert.ToInt32(Console.ReadLine());

Console.Write("Введите столбец массива': ");
n =  Convert.ToInt32(Console.ReadLine());
}

if (m <= 10 && n <= 10)
Console.Write($"Элемент {m} {n} присутствует и равен {array[m-1,n-1]} "  );
else
Console.Write($"Элемент {m} {n} отсутствует"  );
*/
//
//--------------------------------------------------------------------------------------------------
//
/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = new int[5,5];

double Sum = 0;
     
    void ShowArray(int[,] array)
{
        for(int i = 0; i < 5; i++)
        {
        for(int j = 0; j < 5; j++)
        {
            array[i,j] = new Random().Next(-10,10);
            Console.Write(array[i,j] + "     ");
        }
            Console.WriteLine();
        
        }
}
ShowArray(array);

for(int j = 0; j < 5; j++)
        {
        Sum = 0;
        for(int i = 0; i < 5; i++)
        {
            Sum = array[i,j] + Sum;
        }
Sum = Sum / 5;
            Console.Write($"{Sum}   ");
        
        }
*/

