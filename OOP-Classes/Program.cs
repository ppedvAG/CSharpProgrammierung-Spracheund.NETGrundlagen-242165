using OOP_Classes.Data;

namespace OOP_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            // Wir erzeugen hier eine Instanz der Klasse Animal
            var bugs = new Animal("Bugs 🐰");
            bugs.FavoriteFood = "🥕🥕🥕🥕";
            bugs.Birthdate = new DateTime(1940, 7, 27);

            // Wir greifen mit dem Getter auf die Eigenschaft Name zu und geben sie aus
            Console.WriteLine($"Wir haben {bugs.Name} erzeugt.");

            // Wir koennen die Eigenschaft nicht setzen weil sie private ist 
            // und somit vor Manipulation von außen geschuetzt ist
            //bugs.Name = "Daffy 🦆";

            bugs.Eat();
            bugs.Walk();
            bugs.Dispose();
            Console.WriteLine(/* Leerzeile */);

            // Hier erzeugen wir eine weitere Instanz der Klasse Animal
            var duffy = new Animal("Daffy 🦆", new DateTime(1937, 4, 17));
            duffy.FavoriteFood = "🧁🧁🧁";
            duffy.Eat();
            duffy.Walk();
            duffy.Dispose();
        }
    }
}
