/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int numberA;
int numberB;
int numberC;
int max;

Console.WriteLine("Введите челое число A: ");

numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число B: ");

numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число C: ");

numberC = Convert.ToInt32(Console.ReadLine());

max = numberA;

if(numberB > max)
{
    max = numberB;
}
if(numberC > max)
{
    max = numberC;
}

Console.WriteLine($"Максимальное число равно {max}");