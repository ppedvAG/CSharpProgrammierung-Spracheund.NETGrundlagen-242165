namespace OOP_Inheritance.Data
{
    public class Duck : AbstractCreature
    {
        public Duck(string name) : base(name + " 🦆") { }

        public override void MakeSound() 
        {
            Console.WriteLine("Quack!");
        }

        public override string Walk()
        {
            return "Die Ente watschelt.";
        }

        public void Swim() { }

        public void Fly() { }
    }
}
