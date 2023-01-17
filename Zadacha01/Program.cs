Console.WriteLine("Ввидите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввидите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine("Первое число " + numA + " больше чем второе " + numB);
}
else
{
    Console.WriteLine("Второе число " + numB + " больше чем первое " + numA);
}

Console.WriteLine();