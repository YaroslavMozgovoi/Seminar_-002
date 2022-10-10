// Задача 11.Напишите программу.
// 1. Которая будет принимать на вход два числа.
// 2. И выводить, является ли второе число кратным первому. 
// 3. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("введите первое число:");
int numberA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("введите вторрое число:");
int numberB = Convert.ToInt32 (Console.ReadLine());

int division = numberA % numberB;

if(division == 0)
{
    Console.WriteLine("Является кратным");
}
else 
{
    Console.WriteLine($"Неявляется кратным. Остаток = {division}");
}