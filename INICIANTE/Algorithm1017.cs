namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1017
{
    public Algorithm1017()
    {
        (int HorasViagem, int VelocidadeMedia) = (Input(), Input());

        double QuantidadeLitros = HorasViagem * (VelocidadeMedia / 12f);

        Console.WriteLine("{0:F3}", QuantidadeLitros);
    }

    static int Input() =>
       int.Parse(Console.ReadLine()?.Trim() ?? "0");
}
