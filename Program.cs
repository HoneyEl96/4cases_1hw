// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

//если а меньше б, то б это макс, если нет, то макс это а

// Console.Write("Введи число a ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи число b ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a < b)
// {
// Console.WriteLine("max = " + b );
// }
// else
// {
// Console.WriteLine("max = " + a);
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введи число a ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи число b ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи число c ");
// int c = Convert.ToInt32(Console.ReadLine());
// if (a < b) 
// {
// Console.Write("max " + b );
// }
// else if (c < b)
// {
// Console.Write("max " + c );
// }
// else
// {
// Console.Write("max " + a );
// }

//работает неправильно

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("c");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 2 == 0) 
// {
// Console.Write("четное");
// }
// else
// {
// Console.Write("не четное");    
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Введи число ");
// int a = Convert.ToInt32(Console.ReadLine());
// int even = 2; // четное, стартовал с 2х, потому что вусловии начинается от 1, а 1 - не четное
// while (even <= a) // цикл повторяется, пока четное <= введенному числу
// {
// Console.Write(even + " ");
// even +=2; // повторяю even 2 раза, вместо предыдущего even++, even++
// }