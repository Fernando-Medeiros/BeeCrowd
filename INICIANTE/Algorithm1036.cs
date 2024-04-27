namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1036
{
    public Algorithm1036()
    {
        (double A, double B, double C) = Input();

        double Delta = Math.Pow(B, 2) - 4 * A * C;

        if (Delta < 0 || A == 0 || B == 0 || C == 0)
        {
            Console.WriteLine("Impossivel calcular");
            return;
        }

        double R1 = (-B + Math.Sqrt(Delta)) / (2 * A);
        double R2 = (-B - Math.Sqrt(Delta)) / (2 * A);

        Console.WriteLine("R1 = {0:F5}\nR2 = {1:F5}", R1, R2);
    }

    static (double, double, double) Input()
    {
        var input = Console.ReadLine()?.Trim() ?? "0,0 0,0 0,0";

        var dados = input.Split(' ');

        return (double.Parse(dados[0]),
                double.Parse(dados[1]),
                double.Parse(dados[2]));
    }
}
