/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
SortArrayRows(array);



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

void SortArrayRows(int[,] array)
    {
    for (int i=0; i<array.GetLength(0);i++)
        {
        int mistake = 1;
        while (mistake > 0)   //Упорядочивание элементов массива по возрастанию (hw5 HardStat)
            {
            mistake = 0;
            for (int j = 0; j < array.GetLength(1)-1; j++)
                {
                if (array[i,j+1] > array[i,j])
                    {
                    int k = array[i,j+1];
                    array[i,j+1] = array[i,j];
                    array[i,j] = k;
                    mistake++;
                    }
                }
            }
        }
    Console.WriteLine();
    Console.WriteLine("Массив, отсортированный по убыванию элементов в каждой строке:");
    PrintArray(array);

    }