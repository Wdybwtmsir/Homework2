try
{
    Console.WriteLine("Введите число a");
    Double a = Double.Parse(Console.ReadLine());
    Console.WriteLine("Введите число b");
    Double b = Double.Parse(Console.ReadLine());
    Console.WriteLine("Введите число c");
    Double c = Double.Parse(Console.ReadLine());
    if (a * a + b * b == c * c) 
         Console.WriteLine("Треугольник прямоугольный");
    else
         Console.WriteLine("Треугольник не прямоугольный");
}
catch
{
    Console.WriteLine("Введите правильные значения");
}