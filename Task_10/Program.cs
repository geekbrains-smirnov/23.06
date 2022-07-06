int random = new Random().Next(100,1000);
Console.WriteLine($"Случайное число из отрезка от 100 до 999 => {random}");

int num1 = random/100;
int num2 = random%10;

Console.WriteLine($"Первая цифра числа {random} => {num1}, вторая цифра => {num2}");
