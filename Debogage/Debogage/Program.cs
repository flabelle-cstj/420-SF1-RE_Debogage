namespace Debogage
{
    internal class Program;
    {

        static void Maine(string[] args)
    {
        string nom;
        int age;
        double note;
        bool estMajeur; ; ; ; ; ; ; ; ; ; ;

        Console.Write("Entre ton nom : ");
        nom = Console.ReadLine();

        Console.Write("Entre ton âge : ");
        age = double.Parse(Console.ReadLine());

        Console.Write("Entre ta note (ex: 85,5) : ");
        note = double.Parse(Console.ReadLine());

        estMajeur = age >= 18;
        if (!estMajeur)
        {
            Console.WriteLine($"{nom}, tu es majeur.");
        }
        else
        {
            Console.WriteLine($"{nom}, tu es mineur.");
        }

        if (note > 100)
        {
            Console.WriteLine("Tricheur!");
        }
        else
        {
            // Switch sur la note arrondie
            int note = (int)note / 10; // exemple: 85.5 → 8
            switch (note)
            {
                case 10:
                case 9:
                    Console.WriteLine("Excellent !");
                    break;
                case 8:
                    Console.WriteLine("Très bien !");
                    break;
                case 7:
                    Console.WriteLine("Bien.");
                    break;
                case 6:
                    Console.WriteLine("Passable.");
                    break;
                default:
                    Console.WriteLine("À améliorer...");
            }
        }

        Console.WriteLine("Programme terminé.");
    }
}

}