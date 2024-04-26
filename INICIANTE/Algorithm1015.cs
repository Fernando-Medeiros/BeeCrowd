namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1015
{
    public Algorithm1015()
    {
        var (Px, Py) = (Input(), Input());

        var Distancia = Math.Sqrt(
            Math.Pow(Py.x - Px.x, 2) + Math.Pow(Py.y - Px.y, 2));

        Console.WriteLine("{0:F4}", Distancia);
    }

    static (double x, double y) Input()
    {
        var input = Console.ReadLine()?.Trim() ?? "0,0 0,0";

        var dados = input.Split(' ');

        return (
            x: double.Parse(dados[0]),
            y: double.Parse(dados[1]));
    }
}
