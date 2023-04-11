// Seminar 2

// Task 1. Программа, кот выводит случайное трехзначное число и удаляет вторую цифру этого числа

// int CutNumber (int num)
// {
//     int hundreeds = num / 100;
//     int units = num % 10;
//     int result = hundreeds * 10 + units;
//     return result;
// }

// int randNumber = new Random().Next(100,1000);
// int shortNumber = CutNumber(randNumber);

// Console.WriteLine($"New version of {randNumber} is {shortNumber}");


// Task 1 Напишите программу, которая выводит случайное число из отрезка
// [10, 99] и показывает наибольшую цифру числа.

// int MaxUnit (int num)
// {
//     int tens = num / 10;
//     int units = num % 10;
//     if(tens > units) return tens;
//     else return units;
// }
// int randNumber = new Random().Next(10,100);
// int result = MaxUnit (randNumber);
// Console.WriteLine($"Number is {randNumber}. The most number is {result}");

// Task 2 Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому.

// bool TrueF(int num1, int num2)
// {
//     if(num2 % num1 == 0)
//     return true;
//     else 
//     return false;
// }
// Console.WriteLine("Введите два числа");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int num4 = Convert.ToInt32(Console.ReadLine());
// bool result = TrueF(num3,num4);
// Console.WriteLine(result);

// Task 3 Напишите программу, которая принимает на вход число n и проверяет,
// кратно ли оно одновременно a и b.

// bool TrueF(int number, int num1, int num2)
// {
//     if(number % num1 == 0 && number % num2 == 0)
//     return true;
//     else 
//     return false;
// }
// Console.WriteLine("Введите три числа");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int num4 = Convert.ToInt32(Console.ReadLine());
// int num5 = Convert.ToInt32(Console.ReadLine());
// bool result = TrueF(num3,num4,num5);
// Console.WriteLine(result);

//Task 3 Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.

// bool Square(int num1, int num2)
// {
//     if ( (num1 * num1 == num2)||(num2 * num2 == num1) )
//         return true;
//     else 
//         return false;
// }
// Console.WriteLine("Введите два числа");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// bool result = Square(num1,num2);
// Console.WriteLine(result);