﻿// See https://aka.ms/new-console-template for more information

/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8 12-> 2 85 -> 8
10 99
*/
// Random random = new Random();
// int randomValue = random.Next(10, 100);

// GetMaxNumberRandomValue();
// GetMaxNumberRandomValue();
// GetMaxNumberRandomValue();
// GetMaxNumberRandomValue();

// void GetMaxNumberRandomValue()
// {
//     int randomValue = new Random().Next(10, 100);

//     Console.WriteLine($"Random value - {randomValue}");

//     int lastNumber = randomValue % 10;
//     int firstNumber = randomValue / 10;

//     int max = lastNumber;


//     if (lastNumber == firstNumber)
//     {
//         Console.WriteLine($"Числа равны!");
//     }
//     else
//     {
//         if (max < firstNumber)
//         {
//             max = firstNumber;
//         }
//         Console.WriteLine($"Max = {max}");
//     }
// }




// // Seminar 1
// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());


// if (num1 > num2)
// {
//     Console.WriteLine("Первое число " + num1 + " больше чем второе " + num2);
// }
// else
// {
//     Console.WriteLine("Второе число " + num2 + " больше чем первое " + num1);
// }




// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.WriteLine("Введите 3 числа:");
// int num_1 = Convert.ToInt32(Console.ReadLine());
// int num_2 = Convert.ToInt32(Console.ReadLine());
// int num_3 = Convert.ToInt32(Console.ReadLine());


// int max = num_1;


// if (num_2 > max)
// {
//     max = num_2;
// }


// if (num_3 > max)
// {
//     max = num_3;
// }


// Console.WriteLine("Наибольшее из введённых чисел -> " + max);



// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// int num;
// Console.WriteLine("Введите число:");
// num = Convert.ToInt32(Console.ReadLine());


// if (num % 2 == 1)
// {
//     Console.WriteLine("Число " + num + " Нечетное");
// }
// else
// {
//     Console.WriteLine("Число " + num + " Четное");
// }





// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


// int i = 1, num;
// bool logic = true;

// Console.WriteLine("Введите число:");
// num = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Чётные числа от 1 до " + num);
// while (i <= num)
// {
//     if (i % 2 != 1)
//     {
//         Console.Write(i + ", ");
//         logic = false;
//     }
//     i++;
// }

// if (logic)
// {
//     Console.WriteLine("Нет чётных чисел!");
// }





// Seminar 2
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Clear();	
// Console.Write("Введите трёхзначное число: ");
// int newNumber = Convert.ToInt32(Console.ReadLine()); //read from console
// string resultNumber = Convert.ToString(newNumber); // convert to string
// Console.WriteLine("вторая цифра этого числа -> "+resultNumber[1]); // indexes start from 0, so second index equal to 1.



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Clear();

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
string userNumberText = Convert.ToString(userNumber);
if (userNumberText.Length > 2)
{
    Console.WriteLine("третья цифра -> " + userNumberText[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}

