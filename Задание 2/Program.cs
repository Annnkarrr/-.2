// Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

System.Console.Write("Введите координату Х: ");
int coordinate_X = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Y: ");
int coordinate_Y = Convert.ToInt32(Console.ReadLine());

/*if (coordinate_X = 0 || coordinate_Y = 0)
{
    System.Console.WriteLine("Координата равна 0 ");
}*/

if (coordinate_X > 0 && coordinate_Y > 0)
{
    System.Console.WriteLine($"Координаты ({coordinate_X}, {coordinate_Y}) лежат в 1 плоскости ");
}
if ( coordinate_X < 0 && coordinate_Y > 0)
{
    System.Console.WriteLine($"Координаты ({coordinate_X}, {coordinate_Y}) лежат во 2 плоскости ");
}
if (coordinate_X < 0 && coordinate_Y < 0)
{
    System.Console.WriteLine($"Координаты ({coordinate_X}, {coordinate_Y}) лежат в 3 плоскости ");
}
if ( coordinate_X > 0 && coordinate_Y < 0)
{
    System.Console.WriteLine($"Координаты ({coordinate_X}, {coordinate_Y}) лежат в 4 плоскости ");
}
if (coordinate_X == 0 | coordinate_Y == 0)
{
    System.Console.WriteLine(" Вы ввели координату равную 0");
}