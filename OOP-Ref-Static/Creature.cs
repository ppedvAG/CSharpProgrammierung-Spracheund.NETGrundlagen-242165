namespace OOP_Ref_Static
{
    // ':' steht fuer die Vererbung oder Implementierung
    // und wir implementieren System.IDisposable
    // IDisposable ist ein ganz besonderes Interface in C# was den Compiler veranlaesst die Klasse aufzuräumen
    public class Creature : IDisposable
    {
        // static Members gelten Instanzuebergreifend
        // (Members sind alle Mitglieder, d.h. Felder, Eigenschaften, Methoden)
        public static int CreatureCount { get; private set; }

        public string Name { get; set; }

        public Creature(string name)
        {
            Name = name;
            Console.WriteLine(name + " was created.");

            CreatureCount++;
        }

        ~Creature()
        {
            Dispose();
        }

        public void Dispose()
        {
            Console.WriteLine(Name + " was destroyed.");
            CreatureCount--;
        }

        /// <summary>
        /// Verrichtet arbeit mit <paramref name="tools"/>.
        /// </summary>
        /// <param name="tools">Die Werkzeuge die verwendet werden sollen.</param>
        /// <returns>Das Ergebnis der Arbeit.</returns>
        public string DoWork(string tools)
        {
            return "Working with " + tools;
        }

        public string DoWork()
        {
            return "Working with hands.";
        }

        // Mit /// koennen wir Kommentare in die Dokumentation einbauen
        // d. h. der Kommentar taucht in Intelli-Sense auf
        /// <summary>
        /// Zeigt die Anzahl der erzeugten Kreaturen an
        /// </summary>
        public static void ShowCount()
        {
            // Wir koennen aber auf keine Members innerhalb der klasse zugreifen
            // wenn diese nicht static sind
            //this.Name = "Creature";

            Console.WriteLine($"Total creature count: {CreatureCount}");
        }
    }
}
