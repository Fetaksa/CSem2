// Напишите программу, которая
// 1. выводит случаейное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 => {number}");

// int firstDigit = number / 10;  //здесь целочисленное деление, остаток отбрасывается
// int secondDigit = number % 10; //здесь получаем остаток от деления на 10

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа равна {firstDigit}");
// else Console.WriteLine ($"Наибольшая цифра числа равна {secondDigit}");

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine ($"Наибольшая цифра числа равна {maxDigit}");
//Тернарный оператор. Если firstDigit > secondDigit тогда(?) записываем в переменную
//maxDigit  firstDigit. Иначе (:) записываем в переменную maxDigit secondDigit

//ещё вариант тернарного оператора
// Console.Write($"Наибольшая цифра числа {number} равна ");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

//встроенный метод Math.
// int result = Math.Max(firstDigit, secondDigit);
// Console.WriteLine($"Результат = {result}");


//пишем метод
int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.Write($"Наибольшая цифра числа равна {maxDigit}");