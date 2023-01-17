Console.Write("Введите число 1: ");
string numberStr1 = Console.ReadLine();
Console.Write("Введите число 2: ");
string numberStr2 = Console.ReadLine();
int number1 = Convert.ToInt32(numberStr1);
int number2 = Convert.ToInt32(numberStr2);


if (number1 > number2)
{
    Console.WriteLine($"Большее число {number1}, меньшее число {number2}");
}
else
{
    Console.WriteLine($"Большее число {number2}, меньшее число {number1}");
}
