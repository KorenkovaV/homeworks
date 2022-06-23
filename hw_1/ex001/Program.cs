/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int numberA;
int numberB;

Console.WriteLine("Введите челое число A: ");

numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число B: ");

numberB = Convert.ToInt32(Console.ReadLine());

if(numberA == numberB)
{
    Console.WriteLine("Вы ввели одинаковые числа");
}
else
{
    if(numberA > numberB)
    {
        Console.WriteLine($"Число {numberA} больше числа {numberB}");
    }
    else
    {
        Console.WriteLine($"Число {numberB} больше числа {numberA}");
    }
}
