namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1010
{
    public Algorithm1010()
    {
        var (A, B) = (Input(), Input());

        double Total = (A.quantidade * A.valor) + (B.quantidade * B.valor);

        Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", Total);
    }

    static (int codigo , int quantidade, double valor) Input()
    {
        var input = Console.ReadLine()?.Trim() ?? "0 0 0,0";

        var dados = input.Split(' ');

        return (
            codigo: int.Parse(dados[0]),
            quantidade: int.Parse(dados[1]),
            valor: double.Parse(dados[2]));
    }
}
