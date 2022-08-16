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
//     string result = string.Empty;


//     int length  = text.Length;
//     for (int i =0; i< length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
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
// int result = 0;
// for(int i =0; i<n; i++)
// {
//     array[i] = new Random().Next(0,10);
// }
// PrintArray(array);
// for(int i = 0; i<n/2; i++)
// {
//     result = result+ array[i] * array[n-i-1];
//     Console.WriteLine(result);
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




