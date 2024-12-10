namespace footgolf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<footgolf> versenyzok = new();
            foreach (var sor in File.ReadAllLines("fob2016.txt"));

            {
                versenyzok.Add(new versenyzo(sor));

            }

            Console.WriteLine($"1 feladat \t versenyzők száma{versenyzok.Count()}");

            int sor = 0;

            if (s.kategória == "Noi")
            {
               sor == 1;
            }
        }
    }
}
