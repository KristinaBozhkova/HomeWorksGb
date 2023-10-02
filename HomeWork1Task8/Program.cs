// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число :"); //ввод числа с консоли
        int num = int.Parse(Console.ReadLine() ?? "0");

        int evenNum = 2;

        if (num > 1) //проверка условия , отсчет от 1 до N
        {
            while (evenNum <= num)
            {
                Console.Write(evenNum + ",");
                evenNum = evenNum + 2;  //увеличиваем число на 2
            }
        }
        else
        {
            Console.WriteLine("Число не может быть меньше или равно 1, пожалуйста повторите ввод"); //исключение ,если пользователь ввел неверно число
        }
    }
}