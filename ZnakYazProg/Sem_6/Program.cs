/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int size = -1; 

while(1 >= size)
{
Console.Write("Введите количество элементов массива': ");
size =  Convert.ToInt32(Console.ReadLine());
}

// Console.Write("Введите количество элементов массива': ");
//     int size =  Convert.ToInt32(Console.ReadLine());
    
    int N = 0;
    int[] array = new int[size]; //= CreateRandomArray(size,0,99);

// ShowArray(array);


for(int i = 0; i < size; i++)
{
    Console.Write("Введите элемент массива': ");
        array[i] =  Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
        N = N + 1;
}
    void ShowArray(int[] array)
{
        for(int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");

        Console.WriteLine();
}
ShowArray(array);
Console.Write("Количество элементов массива > больше 0 : " +N);

//
//
*/

 /* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

        if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны, пересечения нет");
        }
        else
        {
            double X; 
                X = (b2 - b1) / (k1 - k2);
            double Y1; 
                Y1 = k1 * X + b1;
            double Y2;
                Y2 = k2 * X + b2;
            Console.WriteLine($"Прямые пересекаются, Точка пересечения :  {X} {Y1}");
        }
   
   // Console.WriteLine($"Прямые пересекаются, Точка пересечения :  {X} {Y1}");

// Console.WriteLine($"Точка пересечения :  {X} {Y1}");

*/