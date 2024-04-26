namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1014
{
    public Algorithm1014()
    {
        var (KM, Combustivel) = (Input(), Input());

        var Consumo = KM / Combustivel;

        Console.WriteLine("{0:F3} km/l", Consumo);
    }

    static double Input() =>
        double.Parse(Console.ReadLine()?.Trim() ?? "0,0");
}
