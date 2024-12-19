using OOP_Inheritance.Data;

namespace OOP_Polymorphismus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            TypeCheckingExample();

            // Wir koennen keine Instanz von AbstractCreature erzeugen
            //var creature = new AbstractCreature("Frankenstein");
            //creature.Walk();

            Console.WriteLine();
            var creatures = CreateCreatures();

            Console.WriteLine("Unser Chor aus Tieren singt...");
            foreach (var creature in creatures)
            {
                Console.Write(creature.Name + " singt:\t");
                creature.MakeSound();
            }
        }

        private static void TypeCheckingExample()
        {
            var bugs = new Bunny("Bugs", 42);

            bool isBunny = bugs is Bunny;
            Console.WriteLine("Ist Bugs vom Typ bunny?" + isBunny);

            bool isCreature = bugs is AbstractCreature;
            Console.WriteLine("Ist Bugs vom Typ Creature?" + isCreature);
        }

        private static AbstractCreature[] CreateCreatures()
        {
            return new AbstractCreature[]
            {
                new Bunny(37),
                new Monkey("Diddy Kong"),
                new Duck("Duffy")
            };
        }
    }
}
