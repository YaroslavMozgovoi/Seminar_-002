// Задача 11. Напишите программу. 
// 1. Которая выводит случайное трёхзначное число.
// 2. Удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Сллучайное трёх значное число =>{number}");

int SecondDigit(int number)
{
   int numb1 = (number / 100)*10;
   int numb2 = number % 10;
   int numb = numb1 + numb2;
   return numb;
}

int numberr = SecondDigit (number);
Console.WriteLine(numberr);