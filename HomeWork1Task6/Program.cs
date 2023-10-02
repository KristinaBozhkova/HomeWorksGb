// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine ("Введи число для проверки : "); //ввод числа с консоли
int number = int.Parse (Console.ReadLine()??"0"); 

Console.WriteLine(number % 2 == 0 ? "Четное" : " Нечетное");// проверка на четность, печать результата

//второй вариант
//Console.WriteLine("Введи число для проверки : "); //ввод числа с консоли
//int number = int.Parse(Console.ReadLine() ?? "0");

//if (number % 2 == 0)
//{
//    Console.WriteLine("Число " + number + "-четное");
//}
//else
//{
//   Console.WriteLine(number + "-нечетное");
//}



