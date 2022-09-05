// See https://aka.ms/new-console-template for more information

/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8 12-> 2 85 -> 8
10 99
*/
Random random = new Random ();
int randomValue = random.Next(10,100);

Console.WriteLine ($"Random value - {randomValue}");

int lastNumber = randomValue % 10;
int firstNumber = randomValue/10;

Console.WriteLine($"LastNumber = {lastNumber}");
Console.WriteLine($"FirstNumber = {firstNumber}");
