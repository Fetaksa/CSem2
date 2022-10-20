// Напишите программу, которая выводит случайное трёхзначное число и
// удаляет вторую цифру из этого числа.

// int firstDigit = number / 10;  //здесь целочисленное деление, остаток отбрасывается
// int secondDigit = number % 10; //здесь получаем остаток от деления на 10
// Console.Write($"Полученное число: {firstDigit}{thirdDigit}");

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число => {number}");

// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int newDigit = firstDigit * 10 + thirdDigit;

int DelSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    
    return firstDigit*10 + thirdDigit;
}

int newDigit = DelSecondDigit(number);
Console.Write($"Полученное число: {newDigit}");