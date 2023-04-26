// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число:");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число:");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());

int Max = FirstNumber;

if (Max < SecondNumber)
{
    Max = SecondNumber;
}

if (Max < ThirdNumber)
{
    Max = ThirdNumber;
}

Console.WriteLine("Max = " + Max);
