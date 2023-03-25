/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
На входе - натуральное число от пользователя, например 4.
Тогда на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.WriteLine("Введите порядок квадратной матрицы:");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [n, n];

SpiralArray(n);
PrintArray(array);


void SpiralArray (int n)
{

int imin = 0;
int imax = n-1;
int jmin = 0;
int jmax = n-1;

int k = 0;
int i = 0;
int j = -1;

for(int s=0; s<=n; s++)
    {
    while ( j<jmax)
        {
        k++;
        j++;
        //Console.WriteLine("i:" + i);
        //Console.WriteLine("j:" + j);
        array[i,j] = k;
        }
    imin++;

        while (i<imax)
        {
        k++;
        i++;
        //Console.WriteLine("i2:" + i);
        //Console.WriteLine("j2:" + j);
        array[i,j] = k;
        }
        jmax--;

        while (j>jmin)
        {
        k++;
        j--;
        //Console.WriteLine("i3:" + i);
        //Console.WriteLine("j3:" + j);
        array[i,j] = k;
        }
        imax--;

        while (i>imin)
        {
        k++;
        i--;
        //Console.WriteLine("i4:" + i);
        //Console.WriteLine("j4:" + j);
        array[i,j] = k;
        }
    jmin++;
    //Console.WriteLine("S:" + s);
    }
}


void PrintArray(int[,] array)
    {
    Console.WriteLine();
    Console.WriteLine("Двумерный массив, заполненный спирально: ");
    for (int i=0; i<array.GetLength(0);i++)
        {
        for (int j=0; j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],2} \t");
        Console.WriteLine();
        }
    }
