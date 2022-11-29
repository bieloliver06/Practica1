namespace Practica1
{
    class Program
    {
        static void Main()
        {
            int n;
            int added = 0;
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
                        n = int.Parse(input);
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid : ");
                    }
                }
            }
            while (i < n)
            {
                lastChecked++;
                if (lastChecked % 2 == 0)
                {
                    added += lastChecked;
                    i++;
                    lastChecked++;
                }
            }
            Console.WriteLine($"La suma dels primers {n} nombres parells dona : {added}");
        }
    }
}