namespace OOP_Inheritance.Data
{
    public class Duck : Creature
    {
        public Duck(string name) : base(name + " 🦆") { }

        public override void MakeSound() 
        {
            Console.WriteLine("Quack!");
        }

        public void Swim() { }

        public void Fly() { }
    }
}
