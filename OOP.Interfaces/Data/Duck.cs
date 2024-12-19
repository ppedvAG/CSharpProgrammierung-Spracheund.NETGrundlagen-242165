using OOP.Interfaces.Contracts;

namespace OOP.Interfaces.Data
{
    public class Duck : AbstractCreature, IPilot, ISwimmingPoolAttendant, IWorker
    {
        public string Job { get; set; }

        public Duck(string name) : base(name + " 🦆") 
        {
            Job = "Bademeister";
        }

        public override void MakeSound() 
        {
            Console.WriteLine("Quack!");
        }

        public override string Walk()
        {
            return "Die Ente watschelt.";
        }

        public void Fly()
        {
            Console.WriteLine("Die Ente fliegt.");
        }

        public void Swim()
        {
            Console.WriteLine("Die Ente als Schwimmer rettet leben.");
        }

        public string DoWork()
        {
            Console.WriteLine($"{Name} arbeitet als {Job} und rettet leben!");

            return "Hier dein Leben!";
        }
    }
}
