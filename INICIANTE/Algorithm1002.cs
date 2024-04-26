namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1002
{
    public Algorithm1002()
    {
        double N = 3.14159;
        double Raio = double.Parse(Console.ReadLine() ?? "0");
        double Area = N * Math.Pow(Raio, 2);
        Console.WriteLine($"A={Area:F4}");
    }
}
