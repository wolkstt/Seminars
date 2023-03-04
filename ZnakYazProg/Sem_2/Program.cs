
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

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
        int result2 = ( num/100 );// % 10;
        Console.WriteLine($"Первое число: {result2}");
        Console.WriteLine($"Второе число: {result1}");
        Console.WriteLine("Третье число: " + num % 10 );
    } 
    else 
        Console.WriteLine("Число не является трехзначным!");
    }
