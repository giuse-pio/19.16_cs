namespace _19._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> premi = new List<int> { 100, 300, 500, 700, 200, 1000};
            int premiomin;
            int premiomax;
            Console.WriteLine("inserisci il numero minimo");
            while (!int.TryParse(Console.ReadLine(), out premiomax))
            {
                Console.WriteLine("Errore");
            }
            Console.WriteLine("inserisci il numero massimo");
            while (!int.TryParse(Console.ReadLine(), out premiomin)) 
            {
                Console.WriteLine("Errore");
            }
            Console.WriteLine();

            foreach (int premio in premi)
            {
                if(premio >= premiomax && premio <= premiomin)
                {
                    Console.WriteLine(premio);
                }
            }
        }

    }
}
