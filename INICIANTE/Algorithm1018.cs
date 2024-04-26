namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1018
{
    public Algorithm1018()
    {
        int ValorInicial = Input();

        double Sub = ValorInicial;

        Console.WriteLine(ValorInicial);

        CalcularCedulas(ref Sub, 100);
        CalcularCedulas(ref Sub, 50);
        CalcularCedulas(ref Sub, 20);
        CalcularCedulas(ref Sub, 10);
        CalcularCedulas(ref Sub, 5);
        CalcularCedulas(ref Sub, 2);
        CalcularCedulas(ref Sub, 1);
    }

    static void CalcularCedulas(ref double total, int cedula)
    {
        var quantidade = Math.Floor(total / cedula);

        total -= quantidade * cedula;

        Console.WriteLine(
            $"{quantidade:F0} nota(s) de R$ {cedula:F2}".Replace('.', ','));
    }

    static int Input() =>
       int.Parse(Console.ReadLine()?.Trim() ?? "0");
}
