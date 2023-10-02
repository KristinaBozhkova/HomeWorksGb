// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

internal class Program
{
    private static void Main(string[] args)
    {   
        Console.WriteLine("Введите первое число: ");  //ввод сконсоли первого числа
        int num1 = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Введите второе число: "); //ввод с консоли второго числа
        int num2 = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Введите третье число: "); //ввод с консоли третьего числа
        int num3 = int.Parse(Console.ReadLine() ?? "0");

        int max = num1;  

        if (num2 > num1 ) //проверка условий 
        {
            max = num2;
        
        }
        if (num3 > num2)
        {
            max = num3;
        }
        if (num3 > num1 )
        {
            max = num3;
        }
        Console.WriteLine("Максимальное число " + max); //вывод результата
    }
    
}
