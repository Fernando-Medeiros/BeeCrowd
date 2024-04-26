namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1011
{
    public Algorithm1011()
    {
        var PHI = 3.14159;

        var Raio = Input();

        var VolumeEsfera = (4.0 / 3.0) * PHI * Math.Pow(Raio, 3);

        Console.WriteLine("VOLUME = {0:F3}", VolumeEsfera);
    }

    static double Input() => double.Parse(
        Console.ReadLine()?.Trim() ?? "0,0");
}
