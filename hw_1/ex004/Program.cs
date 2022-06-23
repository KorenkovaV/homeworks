/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int number;
int current = 2;

Console.WriteLine("Введите челое число: ");

number = Convert.ToInt32(Console.ReadLine());

if(number < current)
{
    Console.WriteLine($"Число должно быть не меньше {current}");
}
if(number == current)
{
    Console.WriteLine(current);
}
if(number > 2)
{
    if(number % 2 == 0)
    {
        while(current <= number)
        {
            Console.Write(current + " ");
            current = current + 2;
        }
    }
    else
    {
        while(current < number)
        {
            Console.Write(current + " ");
            current = current + 2;
        }
    }
}
