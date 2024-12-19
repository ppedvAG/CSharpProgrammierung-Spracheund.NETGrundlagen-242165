namespace OOP.Interfaces.Data
{
    // Monkey wird rot unterringelt wenn die abstrakten Methoden nicht implementiert wurden
    public class Monkey : AbstractCreature
    {
        public Monkey(string name) : base(name + " 🙈") 
        {
            FavoriteFood = "🍌🍌🍌";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Oink!");
        }
    }
}
