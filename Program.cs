// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// int[,] table = new int[3, 4];
// FillArrayRandom(table);
// PrintArray(table);
// SortToLower(table);
// Console.WriteLine();
// PrintArray(table);


// // Функция заполнения массива рандомно числами от 1 до 9
// void FillArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// // Функция сортировки элементов в строке двумерного массива, по убыванию
// void SortToLower(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// // Функция вывода двумерного массива
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
// int m = InputNumbers("Введите число строк 1-й матрицы: ");
// int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
// int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

// int[,] firstMartrix = new int[m, n];
// CreateArray(firstMartrix);
// Console.WriteLine($"Первая матрица:");
// WriteArray(firstMartrix);

// int[,] secomdMartrix = new int[n, p];
// CreateArray(secomdMartrix);
// Console.WriteLine($"Вторая матрица:");
// WriteArray(secomdMartrix);

// int[,] resultMatrix = new int[m,p];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"Произведение первой и второй матриц:");
// WriteArray(resultMatrix);

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

// void Print2DArray(int[,] int2DArray)
// {
//     Console.ForegroundColor = ConsoleColor.White;
//     Console.ForegroundColor = ConsoleColor.DarkGreen;

//     for (int i = 0; i < int2DArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < int2DArray.GetLength(1); j++)
//         {
//             //Console.Write($"{i},{j} {int2DArray[i, j]}\t");
//             Console.Write($"{int2DArray[i, j]}\t");

//         }
//         Console.WriteLine();
//     }
//     Console.ForegroundColor = ConsoleColor.White;
// }

// int[,] Create2DimArray(int hight, int length, int min, int max)
// {
//     int[,] int2DArray = new int[hight, length];

//     for (int i = 0; i < hight; i++)
//     {
//         for (int j = 0; j < length; j++)
//         {
//             int2DArray[i, j] = new Random().Next(min, max);
//         }
//     }

//     return int2DArray;
// }


// Console.WriteLine("Cлучайные элементы двумерного массива:");

// // вспомогательный метод, проверяет если элемент в массиве
// bool isInArray(int value, int[,] int2DArray)
// {
//     foreach (int item in int2DArray)
//     {
//         if (item == value) return true;
//     }
//     return false;
// }

// // вспомогательный метод, считаем сколько элементов в массиве
// int countArrayElement(int value, int[,]int2DArray)
// {
//     int counter = 0;
//     foreach (int item in int2DArray)
//     {
//         if (value == item) counter++;
//     }
//     return counter;
// }


// int[,] GetFrequencyArray(int[,] int2DArray)
// {
//     int[,] frequencyArray = new int[int2DArray.Length, 2];
//     int element = 0;

//     // для проверки, если в исходном массиве появиться "0"
//     int zeroElement = 0;

//     foreach (int item in int2DArray)
//     {
//         // изначально frequencyArray состоит из 0, поэтому исключаем еще и "item = 0"
//         // обработаем их дальше в else if
//         if (!isInArray(item, frequencyArray) && item != 0)
//         {
//             frequencyArray[element, 0] = item;
//             frequencyArray[element, 1] = countArrayElement(item, int2DArray);
//         }
//         else if(item == 0 && zeroElement == 0)
//         {
//             frequencyArray[element, 1] = countArrayElement(item, int2DArray);
//             zeroElement++;
//         }
//         element++;
//     }

//     return frequencyArray;
// }

// // вывод частотного массива на консоль
// void PrintFrequencyArray(int[,] frequencyArray)
// {
//     for (int i = 0; i < frequencyArray.GetLength(0); i++)
//     {
//         if(frequencyArray[i,1] != 0)
//             Console.WriteLine($"{frequencyArray[i,0]} встречается {frequencyArray[i,1]} раз");
//     }
// }

// int[,] myArray = Create2DimArray(4, 5, -2, 9);
// Print2DArray(myArray);
// int[,] myFrArray = GetFrequencyArray(myArray);
// PrintFrequencyArray(myFrArray);

