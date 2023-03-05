//-------------------------------------------------------------------------------------------------------------
//=======================ЗАДАНИЕ СЕМИНАРА====ЗАДАНИЕ СЕМИНАРА====ЗАДАНИЕ СЕМИНАРА==============================
//-------------------------------------------------------------------------------------------------------------

/* // Задача 1: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int CutNumber(int num)
{
    int hundreds = num / 100;
    int units = num % 10;
    int result = hundreds * 10 + units;

    return result;
}

int randNumber = new Random().Next(100,1000);
int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
// */

// -----------------------------------------------------------------------------------------------------------

 /* // Задача 2: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

bool IsMultiplyed(int num, int div1, int div2)
{
    if(num % div1 == 0 && num % div2 == 0)
    // if(num % div1*div2 == 0) - не правильно!!! По условию задачи! Нужно условие выполнения a и b меньше num.
        return true;     
    else
        return false;
}
// второй метод:
// bool IsMultiplyedBest(int num, int dev1, int dev2)
// {
//     return num % div1 == 0 && num % div2 == 0;
// }
// 

Console.Write("Input a number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first devider: ");
int devider1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a fsecond devider: ");
int devider2 = Convert.ToInt32(Console.ReadLine());

bool result = IsMultiplyed(number, devider1, devider2);
// Console.WriteLine(result);
if (result)
    Console.WriteLine($"Ваше число {number} делится на {devider1} и на {devider2}");
else
    Console.WriteLine($"Ваше число {number} НЕ ДЕЛИТСЯ на {devider1} и {devider2}");
// */

//-------------------------------------------------------------------------------------------------------------
//=======================ЗАДАНИЯ В ЗАЛАХ====ЗАДАНИЯ В ЗАЛАХ====ЗАДАНИЯ В ЗАЛАХ=================================
//-------------------------------------------------------------------------------------------------------------

/* Задача 3: Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int BiggestNum(int num)
{
    int tens = num / 10;
    int units = num % 10;
    if (units > tens)
        return units;
    else 
        return tens;
}
// return num % div1 == 0 && num % div2 == 0;

int randNumber = new Random().Next(10,100);
int big = BiggestNum(randNumber);

Console.WriteLine($"Случайное число {randNumber} большее число {big}");
*/

// -----------------------------------------------------------------------------------------------------------

/* //  Задача 4: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool SquareOrNot(int num1, int num2)
{
    return (num1 / num2 == num2 || num2 / num1 == num1);
}
Console.Write("Напишите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = SquareOrNot(num1, num2);
if (result)
    Console.WriteLine($"Число {num1} для числа {num2} является квадратом");
else
    Console.WriteLine($"Число {num1} для числа {num2} не является квадратом");
*/

//-------------------------------------------------------------------------------------------------------------
//=======================ДОМАШНЯЯ РАБОТА====ДОМАШНЯЯ РАБОТА====ДОМАШНЯЯ РАБОТА=================================
//-------------------------------------------------------------------------------------------------------------

/* // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// НЕМНОГО МОДИФИЦИРОВАНА, изучал возможности!!!

Console.Write ("Введите 3х значное положительное число от 100 до 255: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int Length = num.ToString().Length;
    if ((num < 100) | (num > 255))
            Console.WriteLine("Число не входит в заданный диапазон!!!");    
    else
    {
        Console.WriteLine("Число входит в заданный диапазон!!!");
    if (Length == 3) 
    {
        int result1 = ( num/10 ) % 10;
        int result2 = ( num/100 );      // % 10;
        Console.WriteLine($"Первое число: {result2}");
        Console.WriteLine($"Второе число: {result1}");
        Console.WriteLine("Третье число: " + num % 10 );
    } 
    else 
        Console.WriteLine("Число не является трехзначным!");
    }

*/
// -----------------------------------------------------------------------------------------------------------

/* // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введи число: ");
    int Number = Convert.ToInt32(Console.ReadLine());
        
        string NumberText = Convert.ToString(Number);

    if (NumberText.Length > 2)
        Console.WriteLine("Третья число: " + NumberText[2]);
    else {
        Console.WriteLine("Число не является трехзначным!");
}

// */
// -----------------------------------------------------------------------------------------------------------

/* // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

bool DayWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7)
    return true;
  else 
    return false; 
}
bool dayweek=DayWeek(dayNumber);
    if (dayweek)
        Console.WriteLine("Ура! ВИхАТной!!!");
    else
    
    if (dayNumber < 1 || dayNumber > 7) 
        Console.WriteLine("Хотелось бы, но увы, в неделе всего 7 дней");
    else
        Console.WriteLine("Пашем, Пашем и ещё раз Пашем!");
    
// */