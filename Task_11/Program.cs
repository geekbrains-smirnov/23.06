Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
double num = 0;

if(Convert.ToInt32(a%b)==0)
{
  Console.WriteLine("Первое число кратное второму числу");
}
if(Convert.ToInt32(a%b)!=0)
{
    num=Convert.ToInt32(a%b);
    Console.WriteLine($"Первое число не кратное второму числу и остаток => {num}");
}


