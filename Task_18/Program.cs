Console.Write("Введите четверть: ");
int a = Convert.ToInt32(Console.ReadLine());
string num_xy (int a)
{
    if (a == 1) return "Диапазон возможных координат в этой четверти x > 0 y > 0";
    else if( a == 2) return "Диапазон возможных координат в этой четверти x < 0 y > 0";
    else if( a == 3) return "Диапазон возможных координат в этой четверти x < 0 y < 0";
    else if( a == 4) return "Диапазон возможных координат в этой четверти x > 0 y < 0";
    else   
    {
        return "Такой четверти не существует";
    }
    
}    
Console.WriteLine(num_xy (a));