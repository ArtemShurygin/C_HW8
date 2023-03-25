/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows, cols];
Console.WriteLine("");

FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
FindMinRow(array);


void FillArray(int[,] array)
    {
    for (int i=0; i<array.GetLength(0);i++)
        for (int j=0; j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(-10,10);
    }

void PrintArray(int[,] array)
    {
    for (int i=0; i<array.GetLength(0);i++)
        {
        for (int j=0; j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3} \t");
        Console.WriteLine();
        }
    }

void FindMinRow(int[,] array)
    {
    Console.WriteLine();
    int minsum = 0;
    int minrow = 0;

    for (int j=0; j<array.GetLength(1);j++) //  Задаем минимальную сумму по первой строке
        minsum+=array[0,j];
    //Console.WriteLine("minsum: " + minsum);

    for (int i=1; i<array.GetLength(0);i++) //  Ищет первую наименьшую строку
        {
        int sum = 0;
        for (int j=0; j<array.GetLength(1);j++)
            {
            sum+=array[i,j];
            };
        if (sum < minsum)
            {
            minsum = sum;
            minrow = i;
            }
        //Console.WriteLine($"Сумма в строке {i+1} равно: {sum}");
        }
    //Console.WriteLine("minsum: " + minsum);
    Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (minrow + 1));
    }