Console.Write("Введите проверочное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int square(int n)
{
     int count = 1;
     int result = 1;
    while (count <= n)
    {
        result = count * count;
        count++;
        Console.WriteLine(result);
        
    }
    return(result);
    
}

Console.WriteLine(square(n));
