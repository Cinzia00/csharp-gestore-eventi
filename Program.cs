namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Console.WriteLine();
            Evento nuovoEvento = new Evento("ciao", "25/09/2023", 12);

            Console.WriteLine(nuovoEvento.DisdiciPosti(5));
            Console.WriteLine(nuovoEvento.ToString());
        }


    }
}