// Задача 1: Напишите программу, которая принимает 
// на вход число и проверяет, кратно ли оно 
// одновременно 7 и 23
// Пример:
// a=50 => Нет
// a=7 => Нет
// a=322 => Да

Console.WriteLine("Введите чиcло: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число для проверки на кратность: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число для проверки на кратность: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int multiplicitytonum1 = a % num1;
int multiplicitytonum2 = a % num2;

if (multiplicitytonum1 == 0 && multiplicitytonum2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
