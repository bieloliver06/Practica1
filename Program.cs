namespace Practica1
{
    class Program
    {
        static void Main()
        {
            int N;
            int added = 0;
            int added2 = 0;
            int lastChecked = 0;
            int i = 1;
            while (true)
            {
                Console.WriteLine("Introdueix quants de nombres parells vols trobar : ");
                string? input = Console.ReadLine();
                if (input != null)
                {
                    try
                    {
                        N = int.Parse(input);
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid : ");
                    }
                }
            }
            while (i < N)
            {
                lastChecked++;
                if (lastChecked % 2 == 0)
                {
                    added += lastChecked;
                    i++;
                    lastChecked++;
                }
            }
            Console.WriteLine($"La suma dels primers {N} nombres parells dona : {added}");
        }
    }
}