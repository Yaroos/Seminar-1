Console.WriteLine("Введите число 1:");
string numberStr1 = Console.ReadLine();
Console.WriteLine("Введите число 2:");
string numberStr2 = Console.ReadLine();
Console.WriteLine("Введите число 3:");
string numberStr3 = Console.ReadLine();
int number1 = Convert.ToInt32(numberStr1);
int number2 = Convert.ToInt32(numberStr2);
int number3 = Convert.ToInt32(numberStr3);
int Max = 0;


if (number1==number2 && number2==number3)
    {
    Console.WriteLine("Введеные числа равны");
    }
if (number1 > number2)
    {
        Max = number1;
    }
else
    {
        Max = number2;
    }
if (Max > number3)
    {
        Console.WriteLine($"Максимальное число номер {Max}");
    }
else
    {
        Console.WriteLine($"Максимальное число номер {number3}");
    }