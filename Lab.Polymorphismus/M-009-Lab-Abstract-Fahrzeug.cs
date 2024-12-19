using System.Text;

namespace Fahrzeugpark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ändern des durch Console verwendeten Zeichensatzes auf Unicode (damit das €-Zeichen angezeigt werden kann)
            Console.OutputEncoding = Encoding.UTF8;

            #region Lab 09: Zufällige Fahrzeuge im Array (Polymorphismus)

            //Arraydeklarierung
            Fahrzeug[] fahrzeuge = new Fahrzeug[10];

            //Schleife über das Array zur Befüllung
            for (int i = 0; i < fahrzeuge.Length; i++)
            {
                //Aufruf der Zufallsmethode aus der Fahrzeug-Klasse
                fahrzeuge[i] = Fahrzeug.GeneriereFahrzeug($"_{i}");
            }

            //Deklarierung/Initialisierung der Zählvariablen
            int pkws = 0, schiffe = 0, flugzeuge = 0;

            //Schleife über das Array zur Identifizierung der Objekttypen
            foreach (var item in fahrzeuge)
            {
                //Ausgabe der ToString()-Methoden
                Console.WriteLine(item as Fahrzeug);
                //Prüfung des Objektstyps und Hochzählen der entsprechenden Variablen
                if (item == null) Console.WriteLine("Kein Objekt vorhanden");
                else if (item is Auto) pkws++;
                else if (item is Schiff) schiffe++;
                else flugzeuge++;
            }

            //Ausgabe
            Console.WriteLine($"Es wurden {pkws} PKW(s), {flugzeuge} Flugzeug(e) und {schiffe} Schiff(e) produziert.");
            //Ausführung der abstrakten Methode
            fahrzeuge[2].Hupen();

            #endregion

        }
    }
}