/* 1. Объяви целочисленные переменные A и B
    int A = 35;
    int B = 20;
    double C = Convert.ToDouble(A)/B;

    Console.WriteLine($"Задача_1____Значение A: {A}  Значение B: {B}  A/B  {C}");

// 6. В A и B рандом от 10 до 99

A = new Random().Next(10,99);
B = new Random().Next(10,99);

Console.WriteLine($"Задача_6____Значение A: {A}  Значение B: {B}");

// 7. Если A > B то в C записываем A / B

if (A > B)
C = Convert.ToDouble(A)/B;
if (A < B)
C = Convert.ToDouble((B)/Convert.ToDouble(A+B));
if (A == B)
C = 0;

Console.WriteLine($"Задача_6____{C}");
*/

/* 2.3 Объявить символьную переменную Зациклить действие пока X не равен символу V

int A;
int B;
char x = 'Q';
double C = 0;

while (x != 'V')
{
A = new Random().Next(10,99);
B = new Random().Next(10,99);


if (A > B)
C = Convert.ToDouble(A)/B;
if (A < B)
C = Convert.ToDouble((B)/Convert.ToDouble(A+B));
if (A == B)
C = 0;

Console.WriteLine($"Задача_6_________Значение A: {A}  Значение B: {B}  A/B  {C}");

Console.Write("Ввести X: ");
    x =  Convert.ToChar(Console.ReadLine());

}
*/

/* 4.

string[] Y = {"3a","2s","5","4g","8"};
int[] Z = {3,2,5,4,8};

int A;
int B;




void ShowArray1(string[] array)
{
        for(int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");

        Console.WriteLine();
}

void ShowArray2(int[] array)
{
        for(int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");

        Console.WriteLine();
}

for(int i = 0; i < Y.Length; i++)

    Z[i] = Y[i].Length;
 
ShowArray1(Y);
ShowArray2(Z);
*/