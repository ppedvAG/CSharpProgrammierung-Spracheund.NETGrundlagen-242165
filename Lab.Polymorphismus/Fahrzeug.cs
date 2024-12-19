namespace Fahrzeugpark
{
    public abstract class Fahrzeug
    {
        //Properties
        public string Name { get; set; }
        public int MaxGeschwindigkeit { get; set; }
        public int AktGeschwindigkeit { get; set; }
        public double Preis { get; set; }
        public bool MotorLäuft { get; set; }

        //Konstruktor mit Übergabeparametern und Standartwerten
        public Fahrzeug(string name, int maxG, double preis)
        {
            Name = name;
            MaxGeschwindigkeit = maxG;
            Preis = preis;
            AktGeschwindigkeit = 0;
            MotorLäuft = false;
        }

        //Methode zur Ausgabe von Objektinformationen
        public virtual string Info()
        {
            if (MotorLäuft)
                return $"{Name} kostet {Preis}€ und fährt momentan mit {AktGeschwindigkeit} von maximal {MaxGeschwindigkeit}km/h.";
            else
                return $"{Name} kostet {Preis}€ und könnte maximal {MaxGeschwindigkeit}km/h fahren.";
        }

        //Methode zum Starten des Motors
        public void StarteMotor()
        {
            if (MotorLäuft)
                Console.WriteLine($"Der Motor von {Name} läuft bereits.");
            else
            {
                MotorLäuft = true;
                Console.WriteLine($"Der Motor von {Name} wurde gestartet.");
            }
        }

        //Methode zum Stoppen des Motors
        public void StoppeMotor()
        {
            if (!MotorLäuft)
                Console.WriteLine($"Der Motor von {Name} ist bereits gestoppt");
            else if (AktGeschwindigkeit > 0)
                Console.WriteLine($"Der Motor kann nicht gestoppt werden, da sich {Name} noch bewegt");
            else
            {
                MotorLäuft = false;
                Console.WriteLine($"Der Motor von {Name} wurde gestoppt.");
            }
        }

        //Methode zum Beschleunigen und Bremsen
        public void Beschleunige(int a)
        {
            if (MotorLäuft)
            {
                if (AktGeschwindigkeit + a > MaxGeschwindigkeit)
                    AktGeschwindigkeit = MaxGeschwindigkeit;
                else if (AktGeschwindigkeit + a < 0)
                    AktGeschwindigkeit = 0;
                else
                    AktGeschwindigkeit += a;

                Console.WriteLine($"{Name} bewegt sich jetzt mit {AktGeschwindigkeit}km/h");
            }
        }


        //statisches Feld für Zufallsgenerator
        protected static Random generator = new Random();
        //Methode zur zufälligen Generierung eines Fahrzeugs
        public static Fahrzeug GeneriereFahrzeug(string nameSuffix = "")
        {
            switch (generator.Next(1, 4))
            {
                //Instanziierung der jeweiligen spezifischen Fahrzeuge
                case 1:
                    return new Auto("Mercedes" + nameSuffix, 210, 23000, 5);
                case 2:
                    return new Schiff("Titanic" + nameSuffix, 40, 25000000, Schiff.SchiffsTreibstoff.Dampf);
                default:
                    return new Flugzeug("Boing" + nameSuffix, 350, 90000000, 9800);
            }
        }

        //Definition einer abstrakten Methode
        public abstract void Hupen();

        //override ToString() überschreibt die Standart-ToString()-Methode
        public override string ToString()
        {
            return this.GetType().Name + ": " + this.Name;
        }
    }
}
