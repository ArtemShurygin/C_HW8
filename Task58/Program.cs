/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

//Условие перемножения: количество столбцов 1-ой матрицы равно числу строк 2-ой матрицы


Console.WriteLine("Введите количество строк 1-ой матрицы:");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1-ой матрицы:");
int cols1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2-ой матрицы:");
int cols2 = Convert.ToInt32(Console.ReadLine());
int rows2 = cols1;

int [,] array1 = new int [rows1, cols1];
int [,] array2 = new int [rows2, cols2];
int [,] array1x2 = new int [rows1, cols2];
Console.WriteLine("");

FillArray(array1);
FillArray(array2);
Console.WriteLine("Первая матрица:");
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintArray(array2);
MultiplyArrays(array1, array2);


void FillArray(int[,] array)
    {
    for (int i=0; i<array.GetLength(0);i++)
        for (int j=0; j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(1,5);
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

void MultiplyArrays(int[,] array1, int[,] array2)
    {

    for (int i=0; i<array1x2.GetLength(0);i++)
        {
        for (int j=0; j<array1x2.GetLength(1);j++)
            {
            int sum =0;
                for (int l=0; l<array1.GetLength(1);l++)
                    sum += array1[i,l] * array2[l,j];
            //Console.WriteLine($"Сумма элемента [{i},{j}] равна: {sum}");
            array1x2[i,j] = sum;
            };
        }
    Console.WriteLine();
    Console.WriteLine("результат перемножения 2-ух матриц:");
    PrintArray(array1x2);
    }