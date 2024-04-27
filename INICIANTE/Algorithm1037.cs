namespace BeeCrowd.INICIANTE;

public sealed class Algorithm1037
{
    public Algorithm1037()
    {
        List<int> Intervalos = new List<int>() {
            0, 25, 25, 50, 50, 75, 75, 100
        };

        double N =
            Convert.ToDouble(Console.ReadLine()?.Trim() ?? "0,0");

        for (int index = 0; index < Intervalos.Count - 1; index += 2)
        {
            var (start, end) = (Intervalos[index], Intervalos[index + 1]);

            if (N >= start && N <= end)
            {
                Console.WriteLine("Intervalo {0}{1},{2}]", end == 25 ? "[" : "(", start, end);
                return;
            }
        }

        Console.WriteLine("Fora de intervalo");
    }
}