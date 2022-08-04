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



