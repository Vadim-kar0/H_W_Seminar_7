// Урок 7. Двумерные массивы
// Операции выводим в методы

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами от -10,0 до 10,0.

// m = 3, n = 4.

// 0,5 7,0 -2,0 -0,2

// 1,0 -3,3 8,0 -9,9

// 8,0 7,8 -7,1 9,0

// void Zapolnenie(double[,] array){
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(-10, 11) + new Random().NextDouble();
//         array[i,j] =  Math.Round(array[i,j], 1);
//     }
// }
// }
// void PechatMassiva(double[,] array){
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
    
// }
// }
// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[rows, columns];

// Zapolnenie(array);
// PechatMassiva(array);


// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


// void Zapolnenie(int[,] array){
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0, 111);
        
//     }
// }
// }
// void PechatMassiva(int[,] array){
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
    
// }
// }
// Console.Write("Введите число для поиска ");
// int chislo = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[5,5];

// Zapolnenie(array);
// PechatMassiva(array);
// int result = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (array[i,j] == chislo)
//         {
//             result = 1;
//             Console.WriteLine($"Индексы числа [{i} , {j}]");
//         }
//     }
// }
// if (result == 0)
// {
//      Console.WriteLine("Такого числа нет в массиве");
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void Zapolnenie(int[,] array){
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0, 11);
        
//     }
// }
// }
// void PechatMassiva(int[,] array){


// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
    
// }
// }

// int[,] array = new int[5,5];

// Zapolnenie(array);
// PechatMassiva(array);
// double summ = 0;
// for (int j = 0; j < array.GetLength(1); j++)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     { 
//        summ += array[i,j];  
//     }
//     j++;
//     Console.WriteLine($"Среднее арифметиеское столбца {j} = {summ/array.GetLength(0)}");
//     j -= 1;
//     summ = 0;
// }