// Задача 9. Напишите программу которая, 
// 1.выводит случайное число из отрезка [10, 99]
// 2. показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100);
Console.WriteLine($"сллучайное число от 10 до 100 : =>{number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
if (firstDigit == secondDigit)
{
    Console.WriteLine("цифры одинаковы");
}
else if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}