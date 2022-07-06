int random = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {random}");

// int firstDigit = random / 10;
// int secondDigit = random % 10; // получим вторую цифру
// int maxDigit = firstDigit;

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;

// if (secondDigit > maxDigit) maxDigit = secondDigit;
// else if(secondDigit == maxDigit) maxDigit = 0;

// if(maxDigit > 0) 
// Console.WriteLine($"Наибольшая цифа числа {random} => {maxDigit}");
// else Console.WriteLine($"Цифры числа {random} равны");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if(firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;

}
int maxDigit = MaxDigit(random);
string result = maxDigit > 0 ? maxDigit.ToString() : "числа равны";
Console.WriteLine($"Наибольшая цифа числа {random} => {result}");
