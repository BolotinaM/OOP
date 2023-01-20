// Создать класс Треугольник. Его поля должны включать углы и стороны треугольника. 
// Реализовать операции: инициализация полей данных с проверкой на их соответствие треугольнику, 
// вычисления периметра треугольника и его площади.

internal class Program
{
    private static void Main(string[] args)
    {
        var x1 = ReadInt("Координата х1: ");
        var y1 = ReadInt("Координата y1: ");

        var x2 = ReadInt("Координата х2: ");
        var y2 = ReadInt("Координата y2: ");

        var x3 = ReadInt("Координата х3: ");
        var y3 = ReadInt("Координата y3: ");


        var A = x2 - x1;
        var B = y2 - y1;

        var C = x3 - x2;
        var D = y3 - y2;

        var E = x1 - x3;
        var F = y1 - y3;

        double lengthAB = Math.Sqrt(A * A + B * B);
        // Console.WriteLine($"От А до B: {lengthAB}");

        double lengthBC = Math.Sqrt(D * D + C * C);
        // Console.WriteLine($"От C до B: {lengthBC}");

        double lengthAC = Math.Sqrt(E * E + F * F);
        // Console.WriteLine($"От А до C: {lengthAC}");

        double perimeter = lengthAB + lengthAC + lengthBC;
        Console.WriteLine($"Значение периметра заданного треугольника равно: {perimeter}");

        double p = (lengthAB + lengthAC + lengthBC) / 2;
        double S = Math.Sqrt(p * (p - lengthAB) * (p - lengthAC) * (p - lengthBC));
        Console.WriteLine($"Значение площади заданного треугольника равно: {S}");

        // Функция вызова
        int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}

// Объявление классов

internal class Triangle {
    public Point? A {get; set;} public Point? B {get; set;} public Point? C {get; set;} 
    public Point? D {get; set;} public Point? E {get; set;} public Point? F {get; set;}
    public Side? lengthAB {get; set;} public Side? lengthBC {get; set;} Side? lengthAC {get; set;}
}

internal class Side 
{
}

public class Point
{
}


