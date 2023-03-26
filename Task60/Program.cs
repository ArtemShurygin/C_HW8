/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте глубину трехмерного массива:");
int depth = Convert.ToInt32(Console.ReadLine());
int [,,] array = new int [rows, cols, depth];
Console.WriteLine("");

FillArray(array);
Console.WriteLine("Исходный массив:");
if (array.GetLength(0)*array.GetLength(1)*array.GetLength(2) <= 90)
    PrintArray(array);



void FillArray(int[,,] array)
    {
    int m = array.GetLength(0)*array.GetLength(1)*array.GetLength(2);
    if (m <= 90)
        {
        int n = 0;
        //Console.WriteLine("m: " + m);
        int [] noarray = new int [m];
        Random rnd = new Random();
        for (int k=0; k<array.GetLength(2);k++)
            for (int i=0; i<array.GetLength(0);i++)
                for (int j=0; j<array.GetLength(1);j++)
                    {
                    int [] ValidValues = Enumerable.Range(0, 100).Except(noarray).ToArray();
                    int num = ValidValues[rnd.Next(9, ValidValues.Length)];
                    array[i,j,k] = num;
                    noarray[n] = num;
                    //Console.WriteLine("n: " + n);
                    //Console.WriteLine("noarray n: " + noarray[n]);
                    n++;
                    //Console.WriteLine("array[i,j,k]: " + array[i,j,k]);
                    //array[i,j,k] = new Random().Next(-10,10);
                    }
        }
    else
        Console.WriteLine("(количество столбцов) * (количество строк) * (глубина) <=90");
    }

void PrintArray(int[,,] array)
    {
    for (int k=0; k<array.GetLength(2);k++)
        {
        Console.WriteLine("Слой: " +(k+1));
        for (int i=0; i<array.GetLength(0);i++)
            {
            for (int j=0; j<array.GetLength(1);j++)
                Console.Write($"{array[i,j,k],2} ({i},{j},{k}) \t");
            Console.WriteLine();
            }
        }
    }