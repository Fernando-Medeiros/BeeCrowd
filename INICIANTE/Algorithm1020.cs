namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1020
{
    public Algorithm1020()
    {
        int TotalDias = Input();

        double D = TotalDias % 365 % 30;
        double M = TotalDias % 365 / 30;
        double A = TotalDias / 365;

        Console.WriteLine($"{A:F0} ano(s)");
        Console.WriteLine($"{M:F0} mes(es)");
        Console.WriteLine($"{D:F0} dia(s)");
    }

    static int Input() =>
       int.Parse(Console.ReadLine()?.Trim() ?? "0");
}
