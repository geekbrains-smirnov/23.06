Console.Write("Введите x: ");
int xx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int yy = Convert.ToInt32(Console.ReadLine());
string check_xy (int x, int y)
{
    if (x > 0 && y > 0) return "первая четверть";
    else if (x > 0 && y < 0)
    {
        return "четвертая четверь";
    }
    else if (x < 0 && y < 0)
    {
        return "третья четверь";

    }
    else if (x < 0 && y > 0)
    {
        return "вторая четверь";
    }
    else return "какая то точка лежит на оси координат";
}
Console.WriteLine(check_xy(xx,yy));