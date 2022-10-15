// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа:");
string numberAStr = Console.ReadLine();
string numberBStr = Console.ReadLine();
string numberСStr = Console.ReadLine();
int numberA = Convert.ToInt32(numberAStr);
int numberB = Convert.ToInt32(numberBStr);
int numberC = Convert.ToInt32(numberСStr);
if(numberA > numberB && numberA > numberC )
{
    Console.WriteLine($"Максимальным числом является {numberA}.");
}
if(numberB > numberA && numberB > numberC )
{
    Console.WriteLine($"Максимальным числом является {numberB}.");
}
if(numberC > numberB && numberC > numberA )
{
    Console.WriteLine($"Максимальным числом является {numberC}.");
}