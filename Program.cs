﻿// Задача 1: Напишите программу, которая принимает 
// на вход число и проверяет, кратно ли оно 
// одновременно 7 и 23
// Пример:
// a=50 => Нет
// a=7 => Нет
// a=322 => Да

// Console.WriteLine("Введите чиcло: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите первое число для проверки на кратность: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число для проверки на кратность: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int multiplicitytonum1 = a % num1;
// int multiplicitytonum2 = a % num2;

// if (multiplicitytonum1 == 0 && multiplicitytonum2 == 0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }
// --------------------------------------------------------------//
// Задача 2: Напишите программу, которая принимает 
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 
// 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.
// Пример: 
// 2, 3 => 1
// -5, 3 => 2
// -3, -2 => 3
// 4, -2 => 4

// Console.WriteLine("Введите первую координату точки: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите вторую координату точки: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("1");
// }
// else if (x < 0 && y > 0)
//     {
//         Console.WriteLine("2");
//     }

//     else if (x < 0 && y < 0)
//     {
//         Console.WriteLine("3");
//     }

//     else if (x > 0 && y < 0)
//     {
//         Console.WriteLine("4");
//     }

//     else
//     {
//         Console.WriteLine("Ошибка ввода! Смотри условие!");
//     }
// --------------------------------------------------------------//
// Задача 3: Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.
// Пример:
// 40 => 4
// 96 => 9
// 72 => 7