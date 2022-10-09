
int number = new Random().Next(10, 1000);

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}

int maxDigit = MaxDigit (number);
Console.WriteLine($"наибоьшее число =>{maxDigit}");