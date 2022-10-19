// Напишите программу, которая
// 1. выводит случаейное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 => {number}");

int firstDigit = number / 10;  //здесь целочисленное деление, остаток отбрасывается
int secondDigit = number % 10; //здесь получаем остаток от деления на 10

if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа равна {firstDigit}");
else Console.WriteLine ($"Наибольшая цифра числа равна {secondDigit}");