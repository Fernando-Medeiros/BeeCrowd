namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1009
{
    public Algorithm1009()
    {
        var NomeVendedor = Console.ReadLine() ?? "Fernando";

        var(SalarioFixo, MontanteTotalVendas) = (Input(), Input());

        double Comissao = 0.15;

        double SalarioComComissao = SalarioFixo + (MontanteTotalVendas * Comissao);

        Console.WriteLine("TOTAL = R$ {0:F2}", SalarioComComissao);
    }

    static double Input() => double.Parse(
        Console.ReadLine()?.Trim() ?? "0,0");
}
