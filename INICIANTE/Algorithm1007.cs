namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1007
{
    public Algorithm1007()
    {
        var (A, B, C, D) = (Input(), Input(), Input(), Input());

        int DIFERENCA = (A * B - C * D);

        Console.WriteLine("DIFERENCA = {0}", DIFERENCA);
    }
    static int Input() => int.Parse(
        Console.ReadLine()?.Trim() ?? "0");
}
