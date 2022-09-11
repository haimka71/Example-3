// See https://aka.ms/new-console-template for more information

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


// Console.Clear();

// Console.Write("Введите число: ");
// int userNumber = Convert.ToInt32(Console.ReadLine());
// string userNumberText = Convert.ToString(userNumber);
// if (userNumberText.Length > 2)
// {
//     Console.WriteLine("третья цифра -> " + userNumberText[2]);
// }
// else
// {
//     Console.WriteLine("-> третьей цифры нет");
// }


// //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// // 6 -> да
// // 7 -> да
// // 1 -> нет


// Console.Clear();

// Console.Write("Введите порядковый номер дня недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());


// void CheckTheDayOfTheWeek(int dayNumber)
// {
//     if (dayNumber == 6 || dayNumber == 7)  // понравилось условие с логическим оператором, условным ИЛИ, мощно условие оптимизирует
//     {
//         Console.WriteLine("(этот день выходной) -> ура! согласен!");
//     }
//     else if (dayNumber < 1 || dayNumber > 7)
//     {
//         Console.WriteLine("упс, ошибочка вышла");
//     }
//     else Console.WriteLine("(этот день не выходной) -> сорри, идем на работу");
// }

// CheckTheDayOfTheWeek(dayNumber);
// // Каюсь, здесь мне помогали разобраться...




// Семинар 3
// ЗАДАЧА 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом (число или текст, читаемый одинаково с обоих сторон).
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Console.Clear();
// Console.Write("Введите пятизначное число: "); 
// string? number = Console.ReadLine(); // преобразование строчного (теста) значения в набор UTF символов

// void CheckNumber(string number)
// {
//   if (number[0]==number[4] && number[1]==number[3]) // если используем ИЛИ || - при вводе 45455 признает полиндромом!
//   {
//     Console.WriteLine($"Ваше число: {number} - палиндром.");
//   }
//   else Console.WriteLine($"Ваше число: {number} - не палиндром.");
// }

// if (number!.Length == 5) //проверка 5-ти значное ли число
// {
//   CheckNumber(number);
// }
// else Console.WriteLine($"Введите корректное число (5 знаков!)");



//ЗАДАЧА 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
	// 3 -> 1, 8, 27
	// 5 -> 1, 8, 27, 64, 125
	

	// Console.Clear();
	// Console.Write("Введите число: ");
	// int cube = Convert.ToInt32(Console.ReadLine());
	

	// void Cube(int[] cube) // вводим не возвращающий метод Cube с аргументом в виде массива, имя cube
    // {
	//   int counter = 0;
	//   int length = cube.Length;
	//   while (counter <  length)
    //   {
	//     cube[counter] = Convert.ToInt32(Math.Pow(counter, 3)); //MathPow метод Возвращает указанное число (counter), возведенное в указанную степень (3).
	//     counter++;
	//   }
	// }
	

	// void PrintArray(int[] coll) // вводим не возвращающий метод PrintArray с аргументом в виде массива, имя coll
    // {
	//   int count = coll.Length;
	//   int index = 0;
	//   while(index < count)
    //   {
	//     Console.Write(coll[index]+ " "); // " " вводим пробел
	//     index++;
	//   }
	// } 
	
	// int[] array = new int[cube+1];
    
	// Cube(array); // вызов метода Cube

	// PrintArray(array); // вызов метода PrintArray




// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
	// A (3,6,8); B (2,1,-7), -> 15.84
	// A (7,-5, 0); B (1,-1,9) -> 11.53
	

    Console.Clear();
	int x1 = Coordinate("x", "A");
	int y1 = Coordinate("y", "A");
	int z1 = Coordinate("z", "A");
	int x2 = Coordinate("x", "B");
	int y2 = Coordinate("y", "B");
	int z2 = Coordinate("z", "B");
	

	int Coordinate(string coorName, string pointName)
	{
	    Console.Write($"Введите координату {coorName} точки {pointName}: ");
	    return Convert.ToInt16(Console.ReadLine());
	}
	

	double Result(double x1, double x2, double y1, double y2, double z1, double z2)
	{
	  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
	                   Math.Pow((y2-y1), 2) + 
	                   Math.Pow((z2-z1), 2));
	}
	

	double LinesegmentLength =  Math.Round (Result(x1, x2, y1, y2, z1, z2), 2 );
	

	Console.WriteLine($"Длина отрезка  {LinesegmentLength}");
