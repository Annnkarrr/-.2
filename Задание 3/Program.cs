// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

System.Console.WriteLine("Введите число от 10 до 99: ");
int number = Convert.ToInt32(Console.ReadLine());
//int max = number % 10;

if (number >= 10 && number <= 99)
{
    int max = number % 10;
    if (max < (number /10 % 10) )
    {
        max = number /10 % 10;
        System.Console.WriteLine($"Наибольшая цифра числа {number} = {max}");
    }
    else
    {
        System.Console.WriteLine($"Наибольшая цифра числа {number} = {max}");
    }

}
else 
{
    System.Console.WriteLine("Число не входит в диапозон");
}
