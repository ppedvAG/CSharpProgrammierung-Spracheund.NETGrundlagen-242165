namespace Fahrzeugpark
{
    //vgl. Schiff
    public class Auto : Fahrzeug
    {
        public int AnzahlTueren { get; set; }

        public Auto(string name, int maxG, double preis, int anzTueren) : base(name, maxG, preis)
        {
            this.AnzahlTueren = anzTueren;
        }

        public override string Info()
        {
            return "Der PKW " + base.Info() + $" Er hat {this.AnzahlTueren} Türen.";
        }
    }
}