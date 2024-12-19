namespace OOP_Inheritance.Data
{
    // Abstract verhindert das Erzeugen von Objekten
    public abstract class AbstractCreature
    {
        public string Name { get; set; }

        public string? FavoriteFood { get; set; }

        // Wir koennen den Constructor protected machen, weil sowieso keine Instanz der Klasse mehr erzeugt werden kann
        protected AbstractCreature(string name)
        {
            Name = name;
        }




        // Wir koennen auch Methoden als abstract definieren. 
        // Wenn wir das tun, dann muessen die abgeleiteten Klassen die Methode in JEDEM FALL ueberschreiben
        // Eine abstrakte Methode darf außerdem keinen Methodenrumpf enthalten
        public abstract void MakeSound(); // Im gegensatz zur normalen Methode steht hier ein ; am Ende. Nicht vergessen!



        // Im Gegensatz zu abstract kann eine virtuelle Methode eine "Standardimplementierung" enthalten
        public virtual string Walk()
        {
            return $"{Name} läuft irgendwo hin.";
        }




        protected void Thinking()
        {
            Console.WriteLine(Name + " denkt irgendwas.");
        }

        public override string ToString()
        {
            return $"{Name} mag gerne {FavoriteFood}.";
        }
    }
}
