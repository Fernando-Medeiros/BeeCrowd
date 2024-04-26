namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1006
{
    public Algorithm1006()
    {
        var (A, B, C) = (Input(), Input(), Input());

        var (WA, WB, WC) = (2, 3, 5);

        double MEDIA = (
            (A * WA) + (B * WB) + (C * WC)
            ) / (WA + WB + WC);

        Console.WriteLine($"MEDIA = {MEDIA:F1}");
    }

    static double Input() => double.Parse(
        Console.ReadLine()?.Trim() ?? "0.0");
}
