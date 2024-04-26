namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1013
{
    public Algorithm1013()
    {
        var (A, B, C) = Input();

        //var Maior =
        //    A > B && A > C ? A :
        //    B > A && B > C ? B :
        //    C;

        var Maior = Max(A, Max(B, C));

        Console.WriteLine("{0} eh o maior", Maior);
    }

    static int Max(int x, int y) => (x + y + Math.Abs(x - y)) / 2;

    static (int, int, int) Input()
    {
        var input = Console.ReadLine()?.Trim() ?? "0 0 0";

        var dados = input.Split(' ');

        return (
            int.Parse(dados[0]),
            int.Parse(dados[1]),
            int.Parse(dados[2]));
    }
}
