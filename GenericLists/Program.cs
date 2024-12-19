using OOP.Interfaces.Contracts;
using OOP.Interfaces.Data;

namespace GenericLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Die Idee hinter Generics ist, dass wir nicht mit der Basisklasse object arbeiten muessen
            // (welche die Basisklasse fuer jedes Objekt ist), sondern gleich mit dem richtigen
            // Typ arbeiten koennen ohne Casts ausfuehren zu muessen.
            var list = new List<AbstractCreature>();
            list.Add(new Bunny());
            list.Add(new Duck("Hugo"));

            // Eine generische Liste existiert nur zur Entwurfszeit
            // Der Compiler wuerde jede Variante der Liste in Code umwandeln
            // List<int> --> ListOfInt32
            // List<AbstractCreature> --> ListOfAbstractCreature
            // Wir sparen uns sehr viel Code-Duplikation weil wir den Code nicht mehrfach schreiben muessen


            List<int> listOfNumbers = [78, 8, 9, 42, 99, 11];
            var secondElementOfList = listOfNumbers[1];

            Console.WriteLine("Existiert 42 in der Liste?");
            Console.WriteLine(listOfNumbers.Contains(42));

            var sortedList = listOfNumbers.OrderBy(x => x).ToList();
            Console.WriteLine("Sortierte Liste:");
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }

            // Im Gegensatz zu einer Liste enthaelt das Dictionary sog. Key-Value Paare
            Dictionary<DayOfWeek, string> menuOfTheWeek = new Dictionary<DayOfWeek, string>();
            menuOfTheWeek.Add(DayOfWeek.Monday, "Pizza");
            menuOfTheWeek.Add(DayOfWeek.Tuesday, "Burger");
            menuOfTheWeek.Add(DayOfWeek.Wednesday, "Kuchen");
            menuOfTheWeek.Add(DayOfWeek.Thursday, "Kuchen");
            menuOfTheWeek.Add(DayOfWeek.Friday, "Kuchen");
            menuOfTheWeek.Add(DayOfWeek.Saturday, "Kuchen");

            var menuForToday = menuOfTheWeek[DayOfWeek.Friday];


            // Wenn wir "mehr Spalten" haben wollen, dann wuerden wir eine Klasse als Value verwenden
            // i. d. R. sollten die Values Datenklassen sein, sog. Modelle.
            // Eine Datenklasse enthaelt ausschliesslich Properties und keine Logik und Methoden
            Dictionary<string, IWorker> workingCreatures = new Dictionary<string, IWorker>();
            workingCreatures.Add("Bunny", new Bunny("Karl", 8));
            workingCreatures.Add("Duck", new Duck("Eve"));

            var bunny = workingCreatures["Bunny"];
            var eve = workingCreatures["Duck"];

            // Das iterieren ueber Dictionaries funktionert etwas anders...
            foreach (KeyValuePair<string, IWorker> pair in workingCreatures)
            {
                string key = pair.Key;
                IWorker creature = pair.Value;
                Console.WriteLine($"{key}: {creature.Name}");
            }

            // Hier wird ein Fehler fliegen weshalb wir pruefen mussen ob der Key existiert
            if (workingCreatures.ContainsKey("May"))
            {
                var may = workingCreatures["May"];
            }

            // Wir koennen auch direkt ueber die Keys/Values iterieren
            // indem wir auf die Properties Keys oder Values zugreifen
            foreach (IWorker creature in workingCreatures.Values)
            {
                Console.WriteLine(creature.Name);
            }


            // Man koennte auch eine Liste als Sonderform eines Dictionaries sehen
            Dictionary<int, string> listLikeDictionary = new Dictionary<int, string>();
            listLikeDictionary.Add(0, "Bunny");
            listLikeDictionary.Add(1, "Duck");

            var firstElementOfDict = listLikeDictionary[0];
        }
    }

    // Beispiel einer Liste ohne Generics; eher unbrauchbar
    // Praktischer waere eine Typisierung wie bei einem Array
    public class ListWithoutGenerics
    {
        public object[] items { get; }

        public ListWithoutGenerics()
        {
            items = new object[10];
        }
    }
}
