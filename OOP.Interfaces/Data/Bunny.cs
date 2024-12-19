using OOP.Interfaces.Contracts;

namespace OOP.Interfaces.Data
{
    public class Bunny : AbstractCreature, IWorker, System.ICloneable
    {
        public string Job { get; set; }

        public Bunny(string name, int earSize) : base(name + " 🐰")
        {
            EarSize = earSize;
            FavoriteFood = "🥕🥕🥕";
            Job = "Entainer";
        }


        // Um Bunny nur mit einem Parameter zu erzeugen wie die Basisklasse muss ich den Konstruktur "überladen"
        public Bunny(int earSize) : this("Bunny", earSize)
        {
            
        }

        // Ein parameterloser Konstruktor nennts sich auch Default-Konstruktor
        public Bunny() : this(0)
        {
            
        }

        public int EarSize { get; }

        public override void MakeSound()
        {
            // Weil MakeSound() abstract duerfen wir sie hier nicht mehr aufrufen
            //base.MakeSound();

            Console.WriteLine("Hup Hup");
            Console.Beep();
            Console.Beep();
        }

        public string Hop()
        {
            var result = Walk();
            return result + " Und springt dann.";
        }

        public string DoWork()
        {
            Console.WriteLine( $"{Name} arbeitet als {Job} und unterhaelt das Publikum!");

            return "Whats'up Doc!";
        }

        public object Clone()
        {
            var clone = new Bunny(Name + " (Klon)", EarSize);
            return clone;
        }
    }
}
