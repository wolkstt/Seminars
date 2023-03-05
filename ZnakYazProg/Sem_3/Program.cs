//
// ======================================================================================================================
/*  Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


 Console.Write("Введи пятизначное число: ");
    int Number = Convert.ToInt32(Console.ReadLine());
        
        string NumberText = Convert.ToString(Number);

    if (NumberText.Length == 5)
        if (NumberText[0] == NumberText[4] && NumberText[1] == NumberText[3])
            Console.WriteLine("Число является палиндромом");
        else
            Console.WriteLine("Число НЕ является палиндромом");
    else 
    {
        Console.WriteLine("Число не пятизначное!!!");
    }
*/
//
// ======================================================================================================================
/*  Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введи Координату 1 точки X: ");
    double X =  Convert.ToDouble(Console.ReadLine());
Console.Write("Введи Координату 1 точки Y: ");
    double Y =  Convert.ToDouble(Console.ReadLine());
Console.Write("Введи Координату 1 точки Z: ");
    double Z =  Convert.ToDouble(Console.ReadLine());
Console.Write("Введи Координату 2 точки X: ");
    double X2 =  Convert.ToDouble(Console.ReadLine());
Console.Write("Введи Координату 2 точки Y: ");
    double Y2 =  Convert.ToDouble(Console.ReadLine());
Console.Write("Введи Координату 2 точки Z: ");
    double Z2 =  Convert.ToDouble(Console.ReadLine());

Console.Write("Введите до какого знака нужна точность: ");
    int touch = Convert.ToInt32(Console.ReadLine());

double dist = (Math.Sqrt ( Math.Pow ( X2-X, 2 ) + Math.Pow ( Y2-Y, 2 ) + Math.Pow ( Z2-Z, 2 )));

Console.WriteLine("Расстояние между точками равно: " + string.Format("{0:N"+touch+"}", dist));

//*/
//
// ======================================================================================================================
//
/* Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введи значение N: ");
    int Num =  Convert.ToInt16(Console.ReadLine());
Console.Write("Введи значение степени N: ");
    int Pow =  Convert.ToInt16(Console.ReadLine());

//         double num1 = Math.Pow (Num,1 );
//         double num2 = Math.Pow (Num,2 );
//         double num3 = Math.Pow (Num,3 );

// Console.WriteLine($"Таблица: " + num1 + " / " + num2 + " / "+ num3 );

Console.Write("Таблица " + Pow + " степени: ");
for (int i = 1; i-1 < Num; i++)
{
    Console.Write(Math.Pow(i,Pow ) + " ");
}
*/