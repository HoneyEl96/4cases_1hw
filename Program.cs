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
// if (a < b && c < b) // если это условие не подходит, то мы понимаем, что число b точно не является максимальным 
// {
// Console.Write("max " + b );
// }
// else if (a < c)
// {
// Console.Write("max " + c );
// }
// else
// {
// Console.Write("max " + a );
// }
// почти не менял условие, по подсказке Алексея: двойным операндом(&&) просто объединил условия исключения одного числа изж трех

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введи число и я определю, четное оно или нет ");
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

Console.Write("Введите номер задачи от 1 до 8: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 9)
{
switch (number)
{
case (1):
// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет
Console.WriteLine("Является ли первое число квадратом второго?");
Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
int c = b * b;
if (a == c)
{
Console.WriteLine("Первое число является квадратом второго");
}
else
{
Console.WriteLine("Первое число не является квадратом второго");
}
break;
case (2):
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
Console.WriteLine("Сейчас определим какое из 2х чисел больше");
Console.WriteLine("Введи число a ");
int d = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число b ");
int e = Convert.ToInt32(Console.ReadLine());
if (d < e)
{
Console.WriteLine("max = " + e );
}
else
{
Console.WriteLine("max = " + d);
}
break;
case (3):
// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.WriteLine("Введи число от 1 до 7 и я скажу, какой это день недели");
Console.WriteLine("Введите число: ");
int f = Convert.ToInt32(Console.ReadLine());
if (f == 1)
{
Console.Write("Понедельник");
}
else if (f == 2)
{
Console.Write("Вторник");
}
else if (f == 3)
{
Console.Write("Среда");
}
else if (f == 4)
{
Console.Write("Четверг");
}
else if (f == 5)
{
Console.Write("Пятница");
}
else if (f == 6)
{
Console.Write("Суббота");
}
else if (f == 7)
{
Console.Write("Воскресенье");
}
else
{
Console.Write("Ошибка");
}
break;
case (4):
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
Console.WriteLine("Введи 3 числа и я скажу, какое из них максимальное");
Console.WriteLine("Введи число a ");
int g = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число b ");
int h = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число c ");
int i = Convert.ToInt32(Console.ReadLine());
if (g < h && i < h)  
{
Console.Write("max " + h );
}
else if (g < i)
{
Console.Write("max " + i );
}
else
{
Console.Write("max " + g );
}
break;
case (5):
// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
Console.WriteLine("Введи число, а я покажу всего его целые числа от -N до N");
Console.WriteLine("Введите число: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Держи, вот же они");
for (int j = -k; j <= k; j++)
{
    Console.Write(" " + j);
}
break;
case (6):
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
Console.WriteLine("Введи число и я определю, четное оно или нет ");
int l = Convert.ToInt32(Console.ReadLine());
if (l % 2 == 0) 
{
Console.Write("четное");
}
else
{
Console.Write("не четное");    
}
break;
case (7):
// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
Console.WriteLine("Введи трехзначное число, а я скажу, какая цифра у него последняя");
Console.WriteLine("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m % 10; // нет защиты от "дурака"
Console.WriteLine(n); // он выдает просто последнее число, потому тут бы сделать условие, где он требует ТОЛЬКО трехзначное число
break;
case (8):
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Давай я скажу, какие числа ДО твоего числа четные");
Console.WriteLine("Введи число ");
int o = Convert.ToInt32(Console.ReadLine());
int even = 2;
while (even <= o)
{
Console.Write(even + " ");
even +=2;
}
break;
}
}
else
{
Console.WriteLine("Введи номер задачки, от 1 до 8, а потом играй с цифрами");
}