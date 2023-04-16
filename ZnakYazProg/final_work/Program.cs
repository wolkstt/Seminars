// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив вводиться с клавиатуры.
int m = 0;
int j = 0;
Console.Write("Введите количество элементов массива, состоящего из строк: ");
    m =  Convert.ToInt32(Console.ReadLine());

string[] ar = new string[m];
string[] final_ar = new string[m];

for(int i = 0; i < m; i++)
    {   Console.Write("Введите значение " + i + "-го элемента массива: ");
        ar[i] = Console.ReadLine();
        if (ar[i].Length <= 3 )
            {final_ar[j]=ar[i];
            j++;
            }
    }

void ShowArray(string[] array, int j)
    {for(int i = 0; i < j; i++)
        Console.Write(array[i] + "  ");
    Console.WriteLine();
    }

Console.WriteLine();
Console.WriteLine("Текущий массив: ");
ShowArray(ar,m);
Console.WriteLine();
Console.WriteLine("Полученный массив: ");
ShowArray(final_ar,j);

