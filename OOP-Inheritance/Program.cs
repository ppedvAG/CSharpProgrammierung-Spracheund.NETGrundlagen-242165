using OOP_Inheritance.Data;

namespace OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            var bugs = new Bunny("Bugs", 42);
            var duffy = new Duck("Duffy");

            Console.WriteLine($"Info zu Bugs: {bugs}");
            bugs.MakeSound();

            Console.WriteLine($"Info zu Duffy: {duffy}");
            duffy.MakeSound();

            var creature = new Creature("Frankenstein");
            creature.Walk();

            // Weil protected member kann darauf nicht zugegriffen werden:
            // 'Creature.Thinking()' is inaccessible due to its protection level
            //creature.Thinking();
        }
    }
}
