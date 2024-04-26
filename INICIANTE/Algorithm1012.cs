namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1012
{
    public Algorithm1012()
    {
        var PHI = 3.14159;

        var (A, B, C) = Input();

        double AreaTriangulo = A * C / 2;
        double AreaCirculo = PHI * Math.Pow(C, 2);
        double AreaTrapezio = ((A + B) * C) / 2;
        double AreaQuadrado = Math.Pow(B, 2);
        double AreaRetangulo = A * B;

        Console.WriteLine("TRIANGULO: {0:F3}", AreaTriangulo);
        Console.WriteLine("CIRCULO: {0:F3}", AreaCirculo);
        Console.WriteLine("TRAPEZIO: {0:F3}", AreaTrapezio);
        Console.WriteLine("QUADRADO: {0:F3}", AreaQuadrado);
        Console.WriteLine("RETANGULO: {0:F3}", AreaRetangulo);
    }

    static (double A, double B, double C) Input()
    {
        var input = Console.ReadLine()?.Trim() ?? "0,0 0,0 0,0";

        var dados = input.Split(' ');

        return (
            A: double.Parse(dados[0]),
            B: double.Parse(dados[1]),
            C: double.Parse(dados[2]));
    }
}
