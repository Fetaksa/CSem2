// Напишите программу, которая принимает на вход число и проверяет,
// является ли оно кратным 7 и 23.

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine($"Число {number} кратно 7 и 23");
// }


// else
// {
//     Console.WriteLine($"Число {number} НЕ кратно 7 и 23");
// }

bool Multiple(int digit, int num1, int num2)
{
    int result1 = digit%num1;
    int result2 = digit%num2;
    if(result1==0 && result2==0) return true;
    return false;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int number1 = 7;
int number2 = 23;

bool result = Multiple(num, number1, number2);
if (result)
{
    Console.WriteLine($"Число {num} кратно 7 и 23");
}

else
{
Console.WriteLine($"Число {num} НЕ кратно 7 и 23");
}