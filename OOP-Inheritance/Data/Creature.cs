namespace OOP_Inheritance.Data
{
    // Jede Klasse leitet sich automatisch vom Typ object ab, aber muessen es nicht hinschreiben.
    public class Creature // : object
    {
        public string Name { get; set; }

        public string FavoriteFood { get; set; }

        public Creature(string name)
        {
            Name = name;
        }

        public string Walk()
        {
            return $"{Name} läuft irgendwo hin.";
        }

        protected void Thinking()
        {
            Console.WriteLine(Name + " denkt irgendwas.");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} macht ein Geräusch.");
        }

        public override string ToString()
        {
            return $"{Name} mag gerne {FavoriteFood}.";
        }
    }
}
