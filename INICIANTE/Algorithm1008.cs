namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1008
{
    public Algorithm1008()
    {
        var FuncionarioID = Input();

        var (Horas, ValorHora) = (Input(), Input());

        double Salario = Horas * ValorHora;

        Console.WriteLine("NUMBER = {0}\nSALARY = U$ {1:F2}", FuncionarioID, Salario);
    }
    static double Input() => double.Parse(
        Console.ReadLine()?.Trim() ?? "0,0");
}
