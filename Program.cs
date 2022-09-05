// See https://aka.ms/new-console-template for more information

/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8 12-> 2 85 -> 8
10 99
*/
// Random random = new Random();
// int randomValue = random.Next(10, 100);

int number = GetMaxNumberRandomValue();

Console.WriteLine(number);


void GetMaxNumberRandomValue()
{
    int randomValue = new Random().Next(10, 100);

    Console.WriteLine($"Random value - {randomValue}");

    int lastNumber = randomValue % 10;
    int firstNumber = randomValue / 10;

    int max = lastNumber;


    if (lastNumber == firstNumber)
    {
        Console.WriteLine($"Числа равны!");
    }
    else
    {
        if (max < firstNumber)
        {
            max = firstNumber;
        }
        Console.WriteLine($"Max = {max}");
    }
}
return 12;



int randomValue = new Random().Next(10, 100);

Console.WriteLine($"Random value - {randomValue}");

int lastNumber = randomValue % 10;
int firstNumber = randomValue / 10;

int max = lastNumber;


if (lastNumber == firstNumber)
{
    Console.WriteLine($"Числа равны!");
}
else
{
    if (max < firstNumber)
    {
        max = firstNumber;
    }
    Console.WriteLine($"Max = {max}");
}



Console.WriteLine($"Max = {max}");

Console.WriteLine($"LastNumber = {lastNumber}");
Console.WriteLine($"FirstNumber = {firstNumber}");
