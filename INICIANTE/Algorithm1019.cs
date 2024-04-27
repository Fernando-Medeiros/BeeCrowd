namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1019
{
    public Algorithm1019()
    {
        int Tempo = Input();

        int S = Tempo % 60;
        int M = Tempo / 60 % 60;
        int H = Tempo / 60 / 60;

        Console.WriteLine("{0}:{1}:{2}", H, M, S);
    }

    static int Input() =>
       int.Parse(Console.ReadLine()?.Trim() ?? "0");
}
