int random = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {random}");

int firstDigit = random / 10;
int secondDigit = random % 10; // получим вторую цифру
int maxDigit = firstDigit;

if (secondDigit > maxDigit) maxDigit = secondDigit;
else maxDigit = 0;

if(maxDigit > 0) Console.WriteLine($"Наибольшая цифа числа {random} => {maxDigit}");
else Console.WriteLine($"Цифры числа {random} равны");

