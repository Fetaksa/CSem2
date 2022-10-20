// Напишите программу, которая будет принимать на вход два числа
// и выводять, является ли первое число кратным второму.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
{
    Console.WriteLine("Первое число кратно второму");
}

else
{   
    Console.WriteLine($"Второе число НЕ кратно первому. Остаток от деления => {number1 % number2}");
}