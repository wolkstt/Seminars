
// СЕМИНАР 5
//-------------------------------------------------------------------------------------------------------------
//=======================ЗАДАНИЯ В ЗАЛАХ====ЗАДАНИЯ В ЗАЛАХ====ЗАДАНИЯ В ЗАЛАХ=================================
//-------------------------------------------------------------------------------------------------------------
//
/* Павел Гуляев: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] ChangePosAndNeg(int[] array)
        {
        for(int i = 0; i < array.Length; i++)
                array[i] *= -1;
        return array;
        }
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void ShowArray(int[] array)
{
        for(int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");

        Console.WriteLine();
}
int[] newArray = CreateRandomArray(12, -9, 9);
ShowArray(newArray);
Console.WriteLine();
ShowArray(ChangePosAndNeg(newArray));


// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
*/
//
//-----------------------------------------------------------------------------------------------------------------------------
//
/* Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

bool FindNumberInArray(int[] array, int number);
{
    for(int i = 0; i < array.Length; i++)
        if (array[i] == number)
            return true;
    return false;
}
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void ShowArray(int[] array)
{
        for(int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");

        Console.WriteLine();
}
Console.WriteLine("");
*/
//
//-----------------------------------------------------------------------------------------------------------------------------
//
/* Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b]

int HowManyNumbers(int[] array, int a, int b)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] >= a && array[i] <= b) counter++;
        return counter;
}
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void ShowArray(int[] array)
{
        for(int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");
        Console.WriteLine();
}
Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input an A requested number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input an B requested number: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
int number = HowManyNumbers(newArray, a, b);
Console.WriteLine($"In new array there are {number} requested number between {a} and {b}");

*/
//
//
//-------------------------------------------------------------------------------------------------------------
//=======================ДОМАШНЕЕ ЗАДАНИЯ====ДОМАШНЕЕ ЗАДАНИЯ====ДОМАШНЕЕ ЗАДАНИЯ==============================
//-------------------------------------------------------------------------------------------------------------

/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


Console.Write("Введите количество элементов массива': ");
    int size =  Convert.ToInt32(Console.ReadLine());

int[] A = CreateRandomArray(size,100,999);
ShowArray(A);

//int[] CreateArray(int size)

// Создает рандомный массив функция на которую подается 3 переменных
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
        int[] array = new int[size];

        for(int i = 0; i < size; i++)
            array[i] = new Random().Next(minValue, maxValue + 1); 
        return array;


}
int S = 0;
for(int i = 0; i < A.Length; i++)
        {
            if (A[i] % 2 == 0)
            S = S + 1;
        }

        Console.WriteLine(S);


void ShowArray(int[] array)
{
        for(int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");

        Console.WriteLine();
}

//
*/
//-----------------------------------------------------------------------------------------------------------------------------
//
/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введите количество элементов массива': ");
    int size =  Convert.ToInt32(Console.ReadLine());

int[] A = CreateRandomArray(size,0,10);
ShowArray(A);



//int[] CreateArray(int size) 
// Создает рандомный массив функция на которую подается 3 переменных
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
        int[] array = new int[size];

        for(int i = 0; i < size; i++)
            array[i] = new Random().Next(minValue, maxValue + 1); 
        return array;


}
int S = 0;
                                                                       
for(int i = 0; i < A.Length; i = i + 2)
        {
            S = S + A[i];
        }
        Console.WriteLine("Сумма четных эементов: " + S);

S = 0;
                                                                       
for(int i = 1; i < A.Length; i = i + 2)
        {
            S = S + A[i];
        }
        Console.WriteLine("Сумма не четных эементов: " + S);

void ShowArray(int[] array)
{
        for(int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");

        Console.WriteLine();
}
// */
//
//-----------------------------------------------------------------------------------------------------------------------------

/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите количество элементов массива': ");
    int size =  Convert.ToInt32(Console.ReadLine());

double[] A = CreateRandomArray(size,0,99);                      // создание массива с ест. числами
ShowArray(A);


// Создает рандомный массив функция на которую подается 3 переменных
double[] CreateRandomArray(int size, int minValue, int maxValue)
{
        double[] array = new double[size];                                // резерв места для массива;

        for(int i = 0; i < size; i++)
            array[i] = new Random().Next(minValue, maxValue + 1); 
        return array;
}
int max = 0;
int min = 0;

        for(int i = 1; i < A.Length; i++)
        {
            if (A[i] > A[max])
            max = i;
            if (A[i] < A[min])
            min = i;
        //Console.WriteLine("шаг цикла i : " + i);
        //Console.WriteLine("min: " + min +" значение " +A[min]);
        //Console.WriteLine("max: " + max +" значение " +A[max]);    
        }

        Console.WriteLine("Разница max и min элементов: " + (A [max] - A [min]) +" "+ (A [max], A [min]) );



void ShowArray(double[] array)
{
        for(int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");

        Console.WriteLine();
}
// */