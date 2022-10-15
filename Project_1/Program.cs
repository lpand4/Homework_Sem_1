// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа:");
string numberAStr = Console.ReadLine();
string numberBStr = Console.ReadLine();
int numberA = Convert.ToInt32(numberAStr);
int numberB = Convert.ToInt32(numberBStr);
if(numberA > numberB)
{
    Console.WriteLine($"Число {numberA} больше, чем число {numberB}");
}
else
{
    Console.WriteLine($"Число {numberB} больше, чем число {numberA}");
}