// for (int i = 2; i<=10; i++)
// {
//     for ( int j = 2; j <=10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j} ");
//     }
//     Console.WriteLine();
// }


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
//             if(array[j] < array[minposition]) minposition = j;
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



