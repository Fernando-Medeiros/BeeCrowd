namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1035
{
    public Algorithm1035()
    {
        (int A, int B, int C, int D) = Input();

        if (B > C &&
            D > A &&
            C + D > A + B &&
            C > 1 && D > 1 &&
            A % 2 == 0)
            Console.WriteLine("Valores aceitos");
        else
            Console.WriteLine("Valores nao aceitos");
    }

    static (int, int, int, int) Input()
    {
        var input = Console.ReadLine()?.Trim() ?? "0 0 0 0";

        var dados = input.Split(' ');

        return (
            int.Parse(dados[0]),
            int.Parse(dados[1]),
            int.Parse(dados[2]),
            int.Parse(dados[3]));
    }
}
