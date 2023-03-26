/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 
// РАЗБИРАЛСЯ С ПРИНЦИПОМ РАБОТЫ ЦИКЛОВ В МАССИВАХ. по этому много коммента. Помогал репетиор. 37 годиков, а я с репетитором.

int m = 0;
int n = 0;

while(0 >= m && 0 >= n) 

{
Console.Write("Введите количество строк массива': ");
m =  Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива': ");
n =  Convert.ToInt32(Console.ReadLine());

}

int[,] array = new int[m,n];
     
    void ShowArray(int[,] array)
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

Console.WriteLine();

int[] temparray = new int[n]; 

        for(int i = 0; i < m; i++)
     {
            for(int j = 0; j < n; j++)
            {
                temparray[j] = array[i,j];
            }
    Array.Sort(temparray);
    Array.Reverse(temparray);
            for(int j = 0; j < n; j++)
            {
                array[i,j] = temparray[j];
            }    

     }
void ShowArray1(int[,] temparray)
{
        for(int i = 0; i < m; i++)
        {
        for(int j = 0; j < n; j++)
        {
            Console.Write(temparray[i,j] + "     ");
        }
            Console.WriteLine();
        
        }
}
ShowArray1(array);
*/
//---------------------------------------------------------------------------------------------------------------------------------
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*

int m = 0;
int n = 0;
int Sum = 0;

while(0 >= m && 0 >= n) 

{
Console.Write("Введите количество строк массива': ");
m =  Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива': ");
n =  Convert.ToInt32(Console.ReadLine());

}

int[,] array = new int[m,n];
int[] sumarray = new int[2];
     
    void ShowArray(int[,] array)
{
        for(int i = 0; i < m; i++)
        {Console.WriteLine(" str90  Берем строку : " + i + " и Запускаем цикл по j");
        for(int j = 0; j < n; j++)
        {Console.WriteLine(" str92    Берем столбец : " + j);
            array[i,j] = new Random().Next(0,10); Console.Write(" str93 присваиваем элементу[" + i + ","+j+"] значение рандомное, которое равно =");
            Console.Write(array[i,j] + "     ");
            Console.WriteLine();     
            if (j==n-1)
            Console.WriteLine("str97 Цикл по j отработал");     
        }
            Console.WriteLine();     
        }
}
ShowArray(array);

Console.WriteLine(" 104  Берем строку 0  и запускаем цикл по j");
        for(int j = 0; j < n; j++)
            { Console.WriteLine("str106 Берем столбец: " + j);
                Console.WriteLine("str107 Значение Sum до выполнения действия = " + Sum + " Значение J = " + j);
                Sum = Sum + array[0,j];
                Console.WriteLine("str109 Значение Sum после выполнения действия = " + Sum + " Значение J = " + j);
                if (j==n-1)
            Console.WriteLine("str111 Цикл по j отработал");     
            }
    
sumarray[0] = Sum;Console.WriteLine("str114 Присваиваем в массив  summarray в нулевой элемент значение суммы Sum ( summarray[0] = Sum )" + sumarray[0]);     
sumarray[1] = 0; Console.WriteLine("str115 Присваиваем в массив  summarray в первый элемент значение строки в которой посчитали сумму ( summarray[1] = 0 )" + sumarray[1]);     

Console.WriteLine("str117 Массив sumarray равен {"+ sumarray[0] +","+sumarray[1]+"}");

            for(int i = 1; i < m; i++)
                { Console.WriteLine("str120 Берем строку: " + i);
                    Sum = 0; Console.WriteLine("str121 Обнуляем сумму Sum, которая равна теперь : " + Sum);
                    for(int j = 0; j < n; j++)
                        {Console.WriteLine("str123 Берем столбец: " + j);
                         Console.WriteLine("str124 Значение Sum до выполнения действия = " + Sum + " Значение j = " + j + "Значение i = " +i+ " Массив sumarray равен {"+ sumarray[0] +","+sumarray[1]+"}");
                            Sum = Sum + array[i,j];
                         Console.WriteLine("str126 Значение Sum после выполнения действия = " + Sum + " Значение j = " + j + "Значение i = " +i+ " Массив sumarray равен {"+ sumarray[0] +","+sumarray[1]+"}");   
                         if (j==n-1)
                            Console.WriteLine("str128 Цикл по j отработал");     
                        }
                        Console.WriteLine("str130 если сумма SUM, которая = "+ Sum + "меньше значения нулевого элемента массива sumarray (sumarray[0]), который =" + sumarray[0] + " то ..." );     
                        if (Sum < sumarray[0]) // проверка условия
                        {
                            sumarray[0] = Sum; Console.WriteLine("str133 Присваиваем в массив  summarray в нулевой элемент значение суммы Sum ( summarray[0] = Sum )" + sumarray[0]);     
                            sumarray[1] = i; Console.WriteLine("str134 Присваиваем в массив  summarray в первый элемент значение строки в которой посчитали сумму ( summarray[1] = i )" + sumarray[1]);     
                            Console.WriteLine("str135 условие отработало Массив sumarray равен {"+ sumarray[0] +","+sumarray[1]+"}");

                        }
                        else 
                         {   Console.WriteLine("str139 условие не отработало, ничего не делали Массив sumarray равен {"+ sumarray[0] +","+sumarray[1]+"}");
                         }
                         if (i==m-1)
                            Console.WriteLine("str142  Цикл по i отработал");     
                }

Console.Write("Строка массива с наименьшей суммой элементов : " + (sumarray[1]+1));
*/

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int m = 0;
int n = 0;
Console.WriteLine("Данная программа перемножает 2 матрицы и выводит на экран результат");

while(0 >= m && 0 >= n) 
{
    Console.Write("Введите количество строк первой матрицы': ");
    m =  Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов первой матрицы': ");
    n =  Convert.ToInt32(Console.ReadLine());
}
int[,] ar1 = new int[m,n];
int[,] ar2 = new int[n,m];
int[,] ar3 = new int[m,m];
  
  void ShowandCreateArray(int[,] array, int m, int n)
{
        for(int i = 0; i < m; i++)
         {
            for(int j = 0; j < n; j++)
            {
                array[i,j] = new Random().Next(0,10);
                Console.Write(array[i,j] + "     ");
            }
            Console.WriteLine();     
        }
}
ShowandCreateArray(ar1,m,n);
Console.WriteLine();
ShowandCreateArray(ar2,n,m);
Console.WriteLine("Результат перемножения матриц:");

for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < m; j++)
        {
            for(int k = 0; k < n; k++)
            {
            ar3[i,j] = ar3[i,j] + ar1[i,k] * ar2[k,j];
            }
        Console.Write(ar3[i,j] + "     ");
        }
        Console.WriteLine();     
    }

    */
// ------------------------------------------------------------------------------------------------------------------
/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
//
int m = 0;
int n = 0;
int o = 0;
Console.WriteLine("Данная программа формирует трёхмерный массив из неповторяющихся двузначных чисел и выводит построчно массив, добавляя индексы каждого элемента.");

while(0 >= m && 0 >= n && 0 >= o ) 
{
    Console.Write("Введите количество 1-ой размерности массива': ");
    m =  Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество 2-ой размерности массива': ");
    n =  Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество  3-ей размерности массива': ");
    o =  Convert.ToInt32(Console.ReadLine());
}
int[,,] ar1 = new int[m,n,o];

  
  void ShowandCreateArray(int[,,] array)
{
        for(int i = 0; i < m; i++)
         {
            for(int j = 0; j < n; j++)
            {
                for(int k = 0; k < o; k++)
                {
                array[i,j,k] = new Random().Next(10,100);
                Console.Write(array[i,j,k] + "  ("+ i + "," + j + "," + k + ")  ");
                }
            }
            Console.WriteLine();     
        }
}
ShowandCreateArray(ar1);
Console.WriteLine();

*/
/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//
int n = 10;

int[,] array = new int[n,n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1))

{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}    
    void ShowArray(int[,] array)
{
        for(i = 0; i<n; i++)
        {
        for(j = 0; j<n; j++)
        {
        //  array[i,j] = new Random().Next(0,10);
            Console.Write(array[i,j] + "     ");
        }
            Console.WriteLine();
        
        }
}
ShowArray(array);
Console.WriteLine();

*/