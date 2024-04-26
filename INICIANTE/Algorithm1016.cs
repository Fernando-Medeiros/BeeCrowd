namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1016
{
    public Algorithm1016()
    {
        int Distancia = Input();

        double Velocidade = (90 - 60) / 60f;

        var Minutos = Distancia / Velocidade;

        Console.WriteLine("{0} minutos", Minutos);
    }

    static int Input() =>
       int.Parse(Console.ReadLine()?.Trim() ?? "0");
}
