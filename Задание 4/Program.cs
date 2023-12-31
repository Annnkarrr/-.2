// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

 while ( N % 10 != 0)
{
    System.Console.WriteLine(N % 10);
    N = N % 10;
}



