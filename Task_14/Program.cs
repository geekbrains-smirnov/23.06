Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 7;
int c = 23;
if((a%b)+(a%c)==0)
{
    Console.WriteLine($"Число {a} кратно {b} и {c} ");
}
else 
{
    Console.WriteLine($"Число {a} не кратно {b} и {c} ");
}
