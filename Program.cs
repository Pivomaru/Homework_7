/* Задача 47: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

/* void Print(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            Console.Write(arr[i, k] + " ");
        }
        Console.WriteLine();
    }

}
int m = 3, n = 4;
double[,] mass = new double[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int k = 0; k < mass.GetLength(1); k++)
    {
         mass[i, k] = new Random().NextDouble() *  10 ;
    }
}

Print(mass);
Console.WriteLine();
Print(mass); */


//////////////////////////////////////


/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */


/* void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }

}
int m = 3, n = 4;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}

Print(mass);
Console.WriteLine();

int find = 5;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)

        if (mass[i, j] == find)
        {
               Console.WriteLine(mass[i, j]);
break;
        }
}
    
    Console.WriteLine("Нет такого элемента"); */

//////////////////////////////////////////////

/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
    Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3. */


void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }

}
int m = 3, n = 4;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}

Print(mass);
Console.WriteLine();

double sum =0;
for (int i = 0; i < mass.GetLength(0); i++)
    {;
        for (int j = 0; j < mass.GetLength(1); j++)
        {
           
            sum = mass[i, j] + mass[i, j];
        
        }
Console.Write($"{ sum / mass.GetLength(0)} ");
    } 

    ///я понимаю суть решенитя, но не понимаю как это pаписать в программу. (Т_Т)