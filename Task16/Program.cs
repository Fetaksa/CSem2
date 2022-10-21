// Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (Math.Sqrt(number1) == number2)
{
    Console.WriteLine($"Первое число {number1} является квадратом второго числа {number2}");
}

else if (Math.Sqrt(number2) == number1)
{
    Console.WriteLine($"Второе число {number2} является квадратом первого числа {number1}");
}

else
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого");
}