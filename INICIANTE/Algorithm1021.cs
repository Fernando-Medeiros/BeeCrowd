namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1021
{
    public Algorithm1021()
    {
        List<double> Notas = new List<double>() { 100.0, 50.0, 20.0, 10.0, 5.0, 2.0 };
        List<double> Moedas = new List<double>() { 1.00, 0.50, 0.25, 0.10, 0.05, 0.01 };

        var Total =
            double.Parse(Console.ReadLine()?.Trim() ?? "0,0");

        Total = (int)(Total * 100);

        Console.WriteLine("NOTAS:");
        foreach (double nota in Notas)
        {
            int quantidade = (int)(Total / (int)(nota * 100));

            Console.WriteLine($"{quantidade} nota(s) de R$ {nota:F2}");
            Total %= (int)(nota * 100);
        }

        Console.WriteLine("MOEDAS:");
        foreach (double moeda in Moedas)
        {
            var quantidade = (int)(Total / (int)(moeda * 100));

            Console.WriteLine($"{quantidade} moeda(s) de R$ {moeda:F2}");
            Total %= (int)(moeda * 100);
        }
    }
}
