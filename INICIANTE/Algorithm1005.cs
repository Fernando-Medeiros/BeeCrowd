namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1005
{
    public Algorithm1005()
    {
        var (A, B) = (Input(), Input());

        var (WA, WB) = (3.5, 7.5);

        double MEDIA = ((A * WA) + (B * WB)) / (WA + WB);

        Console.WriteLine($"MEDIA = {MEDIA:F5}");
    }

    static double Input() => double.Parse(
        Console.ReadLine()?.Trim() ?? "0.0");
}
