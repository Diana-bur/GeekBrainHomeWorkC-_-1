// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число:");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ещё одно число:");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

if (FirstNumber > SecondNumber)
{
    Console.WriteLine("Max = " + FirstNumber);
    Console.WriteLine("Min = " + SecondNumber);
}
else if (SecondNumber > FirstNumber)
{
    Console.WriteLine("Max = " + SecondNumber);
    Console.WriteLine("Min = " + FirstNumber);    
}
else
Console.WriteLine("Числа равны");   