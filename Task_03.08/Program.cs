// for (int i = 2; i<=10; i++)
// {
//     for ( int j = 2; j <=10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j} ");
//     }
//     Console.WriteLine();
// }


// -----------------------------------------------------------------

// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить на маленькие "с"

// string text = " - Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string repalce(string text, char oldValue, char newValue)
// {
//     string result1 = string.Empty;


//     int length  = text.Length;
//     for (int i =0; i< length; i++)
//     {
//         if(text[i] == oldValue) result1 = result1 + $"{newValue}";
//         else result1 = result1 + $"{text[i]}";
//     }
//     return result1;
// }    

// string newText = repalce(text, ' ', '|');
// Console.WriteLine(newText);

// -------------------------------------------------

// int[] arr = {1,5,4,3,2,6,7,1,1};

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for(int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();

// }

// void SelectionSort(int[] array)
// {

//     for (int i = 0; i < array.Length -1; i++)
//     {
//         int minposition = i;

//         for (int j = i+1; j < array.Length; j++)
//         {
//             if(array[j] > array[minposition]) minposition = j;
//         }
//         //
//         //
//         //
//         int tempory = array[i];
//         array[i] = array[minposition];
//         array[minposition] = tempory;
//     }



// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);

// ---------------------------------------------------------------------------------

// Напишите программу которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

// 7 -> 28 
// 4 -> 10
// 8 -> 36


// Console.Write("Введите проверочное число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int summa(int a)
// {
//     int sum = 0;

//     for (int i = 1; i <= a; i++ )
//     {

//          sum = sum + i;  
//     }
//      return sum;


// }


// Console.WriteLine(summa(a));

//------------------------------------------------


// Напишите программу, которая принимает на вход число и выдает количество цифр в числе

// 456 -> 3
// 78 -> 2
// 89126 -> 5


// Console.Write("Введите проверочное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int amount(int num)
// {
//     int count = 0;
//     if( num==0) count =1;

//     while (num != 0)
//         {
//             num = num/10;
//             count++; 

//         }

//     return count;
// }


// Console.WriteLine(amount(num));

// ------------------------------------------------------------------


// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for(int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();

// }
// Console.Write("введите целое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] factor(int n)
// { 
// int[] array = new int[n];
// int f =1;
// for (int i = 1; i <= n; i++)
//     {
//         f = f*i;
//         array[i-1]=f;
//     }
//     return array;
// }    
// PrintArray(factor(n));

// --------------------------------------------------------------------

// напишите программу, которая выводит массив из N элементов, заполненный нулями и единицами в случайном порядке


// void PrintArray(int[] array)
//     {
//         int count = array.Length;

//         for(int i = 0; i < count; i++)
//         {
//             Console.Write($"{array[i]} ");
//         }
//         Console.WriteLine();

//     }
// Console.Write("Введите рамер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] RandomArr(int N)
// {
//     int[] array = new int[N];
//     for (int i =1; i<N; i++)
//     {
//         array[i] = new Random().Next(0,2);
//     }

//     return array;
// }

// PrintArray(RandomArr(N));

// -----------------------------------------------------------------------------



// Задача 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9;9] Найдите сумму отрицательных и положительных элементов массива.


// void PrintArray(int[] array)
//     {
//         int count = array.Length;

//         for(int i = 0; i < count; i++)
//         {
//             Console.Write($"{array[i]} ");
//         }
//         Console.WriteLine();

//     }
// Console.Write("Введите размер массива: ");
// int n = Convert.ToInt32(Console.ReadLine());


//     int [] arr = new int[n];
//     int sum_p = 0;
//     int sum_n = 0;
//     for(int i =0; i<n; i++)
//     {
//         arr[i] = new Random().Next(-9,10);
//         if(arr[i]>0) sum_p = sum_p+arr[i];
//         else sum_n = sum_n+arr[i];
//     }





// PrintArray(arr);
// Console.WriteLine(sum_p);
// Console.WriteLine(sum_n);

// --------------------------------------------------------------------------------------------------

// Задача 32. преобразование элементв массива с положительных на отрицательные.

// void PrintArray(int[] array)
//     {
//         int count = array.Length;

//         for(int i = 0; i < count; i++)
//         {
//             Console.Write($"{array[i]} ");
//         }
//         Console.WriteLine();

//     }
// Console.Write("Введите размер массива: ");
// int n = Convert.ToInt32(Console.ReadLine());


//     int [] arr = new int[n];
//     int sum_p = 0;
//     int sum_n = 0;
//     for(int i =0; i<n; i++)
//     {
//         arr[i] = new Random().Next(-9,10);

//     }
//     PrintArray(arr);
//     for(int i = 0; i<n; i++) arr[i] = arr[i] * -1;





// PrintArray(arr);

// ---------------------------------------------------------------------------


// Задача 33. Задайте массив. Напишите программу, которая определяет присутствует ли заданное число в массиве.

// void PrintArray(int[] array)
//     {
//         int count = array.Length;

//         for(int i = 0; i < count; i++)
//         {
//             Console.Write("["+ String.Join(", ", array) +  "]");
//         }
//         Console.WriteLine();

//     }


// Console.Write("Введите проверочное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] massive = {6,7,19,345,3};
// int i = 0;
// int mass_i = 0;
// bool z = false;

// while (i<massive.Length)
// {
//     if (massive[i]==n) 
//     {
//         z = true;
//         mass_i = i;
//     } 


//     i++;


// }

// PrintArray(massive);

// if (z) Console.WriteLine($"{n} под индексом {mass_i} пристутсвует в массиве");
// else Console.WriteLine("Данного числа нет в массиве");


// -----------------------------------------------------------------


// Задача 35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива значение которых лежат в отрезке [10,99]

// void PrintArray(int[] array)
//     {
//         int count = array.Length;

//         for(int i = 0; i < count; i++)
//         {
//             Console.Write($"{array[i]} ");
//         }
//         Console.WriteLine();

//     }

// Console.Write("Введите размер массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// int count = 0;

// for (int i = 0; i < n; i++)
// {
//     array[i] = new Random().Next(0, 124);
//     if (array[i] > 9 && array[i] < 100)
//     {

//         count++;
//     }

// }

// PrintArray(array);
// Console.WriteLine(count);

// ---------------------------------------------------------------------

// void PrintArray(int[] array)
//     {
//         int count = array.Length;

//         for(int i = 0; i < count; i++)
//         {
//             Console.Write($"{array[i]} ");
//         }
//         Console.WriteLine();

//     }

// Console.Write("Введите размер массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// int result1 = 0;
// for(int i =0; i<n; i++)
// {
//     array[i] = new Random().Next(0,10);
// }
// PrintArray(array);
// for(int i = 0; i<n/2; i++)
// {
//     result1 = result1+ array[i] * array[n-i-1];
//     Console.WriteLine(result1);
// }

// -------------------------------------------------------------------------

// string[,] table = new string[2,5];
// table[1,2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for ( int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"{table[rows, columns]}");
//     }
// }





// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i,j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//         {
//             for (int j = 0; j < matr.GetLength(1); j++)
//             {
//                 matr[i,j] = new Random().Next(1,10);

//             }

//         }
// }
// int[,] matrix = new int[3,4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// -----------------------------------------------------------------------


// double Factorial ( int n)
// {
//     if (n==1) return 1;
//     else return n * Factorial(n-1);
// }
// for (int i =1; i<40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// ------------------------------------------------------------------------------



// double Fibonacci(int n)
// {
//     if (n==1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2); 
// }

// for (int i =1; i< 40; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }

// ----------------------------------------------------------------------------

// Задача 39. Напишите программу которая перевернет одномерный массив.

// void PrintArray(int[] array)
//     {
//         int count = array.Length;

//         for(int i = 0; i < count; i++)
//         {
//             Console.Write($"{array[i]} ");
//         }
//         Console.WriteLine();

//     }

// Console.Write("Введите размер массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];


// for(int i =0; i<n; i++)
// {
//     array[i] = new Random().Next(-9,10);

// }
// PrintArray(array);

// int bath = 0;
// for (int i =0; i<n/2; i++)
// {
//     bath = array[i];
//     array[i] = array[n-1-i];
//     array[n-1-i] = bath;
// }
// PrintArray(array);
// ----------------------------------------------------------------

// Задача 40. Напишите программу которая принимает на вход три числа и проверяет, мжет ли существовать треугольник со сторонами такой длины.
// теорема о неравенстве: Каждая сторона треугольника меньше суммы двух других сторон.

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());


// if (a<(b+c) && b<(a+c) && c<(a+b)) Console.WriteLine("Да - это треугольник");
// else Console.WriteLine("Нет - это не треугольник!");
// -------------------------------------------------------------------------------

// Задача 42. Напишите программу которая будет преобразовывать десятичное число в двоичное.
// 45 - 101101
// 3 - 11
// 2 - 10

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// string res = string.Empty;
// while (a>0)
// {
//     res= (a%2) + res;
//     a = a/2;
// }
// Console.WriteLine(res);

// -------------------------------------------------------------------------

// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i,j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//         {
//             for (int j = 0; j < matr.GetLength(1); j++)
//             {
//                 matr[i,j] = new Random().Next(1,10);

//             }

//         }
// }
// Console.Write("Задайте количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m,n];
// FillArray(array);
// PrintArray(array);

// --------------------------------------------------------------------------------------


// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i,j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//         {
//             for (int j = 0; j < matr.GetLength(1); j++)
//             {
//                 matr[i,j] = i+j;

//             }

//         }
// }
// Console.Write("Задайте количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m,n];
// FillArray(array);
// PrintArray(array);

// ----------------------------------------------------------------------------------

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);

//         }

//     }
// }


// Console.Write("Задайте количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];

// FillArray(array);
// PrintArray(array);
// void ChangeArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 != 0 && j % 2 != 0) array[i, j] = array[i, j]*array[i, j];
//         }
//     }
// }


// Console.WriteLine();

// ChangeArray(array);
// PrintArray(array);

// ------------------------------------------------------------------------------------------


// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }



// Console.Write("Задайте количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);

//         }

//     }
// }


// void ChangeArray(int [,] array)
// {
//     int result1 = 0;
//     int result2 = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
             
//              if(i==j) result1 = result1 + array[i, j];
             
//              else if(i+j==m-1) result2 = result2 + array[i, j];
             
            
            
//         }
        
//     }
//     Console.WriteLine($"{result1} , {result2}");
    
    
// }



// try
// {
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// ChangeArray(array);
// }
// catch
// {
//     Console.WriteLine("Нужно что бы m = n");
// }
// --------------------------------------------------------------------------------------------


// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }



// Console.Write("Задайте количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);

//         }

//     }
// }

// void ChangeArray(int [,] array)
// {
    
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int t = array[0,j];
//             array[0,j] = array[array.GetLength(0)-1,j];
//             array[array.GetLength(0)-1,j] = t;
            
//         }
    
// }

// FillArray(array);
// PrintArray(array);
// ChangeArray(array);
// Console.WriteLine("Образованный масссив: ");
// PrintArray(array);
// ----------------------------------------------------------------------------------------------------


// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, 
// если это невозможно, программа должна вывести сообщение для пользователя.

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }



// Console.Write("Задайте количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);

//         }

//     }
// }

// void TransPons(int [,] array, int [,] array_2)
// {
    
        

//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array_2[i, j] = array[j,i];

//             }

//         }
    
// }

// FillArray(array);
// PrintArray(array);

// Console.WriteLine("Образованный масссив: ");


// int [,] array_2 = new int[n,m];
// try
// {
//     TransPons(array, array_2);
//     PrintArray(array_2);

// }
// catch 
// {
//     Console.WriteLine("Размерности должны быть одинаковы: ");
// } 

// ---------------------------------------------------------------------------------------------------------

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// string create_number(int b)
// {
//   if(1<= b ) return create_number(b - 1) + $"{b}, ";
//   else return string.Empty;
// }

// Console.WriteLine(create_number(6));

// ----------------------------------------------------------------------------------------------------------------------

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"



// string create_number(int a, int b)
// {
//   if(a <= b ) return create_number(a, b - 1) + $"{b}, ";
//   else return string.Empty;

// }

// Console.WriteLine(create_number(3, 6));

// ------------------------------------------------------------------------------------------------------------------------


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// int SumDigit(int n)
// {
//   if (n==0) return 0;
//   else return n%10 + SumDigit(n/10);

// }

// Console.WriteLine(SumDigit(453));

// ------------------------------------------------------------------------------------------------------------------------


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int PowerRec(int a, int b)
{
  if (b==0) return 1;
  else return PowerRec(a, b - 1) *a;

}

Console.WriteLine(PowerRec(3,5));

