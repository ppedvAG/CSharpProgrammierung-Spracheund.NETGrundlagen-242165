namespace OOP_Inheritance.Data
{
    public class Bunny : AbstractCreature
    {
        public Bunny(string name, int earSize) : base(name + " 🐰")
        {
            EarSize = earSize;
            FavoriteFood = "🥕🥕🥕";
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
    }
}
