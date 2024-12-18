using OOP_Classes.Data;

namespace OOP_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Wir erzeugen hier eine Instanz der Klasse Animal
            var bugs = new Animal("Bugs");
            bugs.FavoriteFood = "Karotten 🥕🥕🥕🥕";
            bugs.Birthdate = new DateTime(1940, 7, 27);

            // Wir greifen mit dem Getter auf die Eigenschaft Name zu und geben sie aus
            Console.WriteLine($"Wir haben {bugs.Name} erzeugt.");

            // Wir koennen die Eigenschaft nicht setzen weil sie private ist 
            // und somit vor Manipulation von außen geschuetzt ist
            //bugs.Name = "Daffy Duck";

            bugs.Eat();
            bugs.Walk();

            // Hier erzeugen wir eine weitere Instanz der Klasse Animal
            var duffy = new Animal("Daffy Duck");
            duffy.FavoriteFood = "Spaghetti";
            duffy.Eat();
        }
    }
}
