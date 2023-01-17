// Четное или нечетное число
Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

int Ostatok = number% 2;
if(Ostatok == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}