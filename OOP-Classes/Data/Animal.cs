
namespace OOP_Classes.Data
{
    public class Animal
    {
        // Felder sind Variablen der Klasse
        #region Felder

        // Weil das Feld private ist koennen wir es nur innerhalb der Klasse manipulieren
        private string _name;
        private string name;

        private bool _isAlive = true;

        #endregion

        // Eigenschaften sind spezielle Methoden welche ein Feld lesen/setzen
        #region Eigenschaften

        // Alter Ansatz vor Dekaden war ein Methodenpaar zu definieren
        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        // C# hat Eigenschaften eingefuehrt
        public string Name 
        { 
            get
            {
                // Im Kontext einer Eigenschaft nennt sich das Feld "Backingfield"
                // wenn es fuer ein Feld eine Eigenschaft gibt
                return _name;
            }
            // Wir koennen auch Zugriffsmodifizierer verwenden,
            // so dass die Eigenschaft von außen nicht geschrieben werden kann
            private set
            {
                // value ist ein Keyword welches in sog. "settern" verfuegbar ist 
                _name = value;
            }
        }

        // Alternative Kurzschreibweise mit Backingfield
        public string Name2 { get => _name; private set => _name = value; }

        // Bei dieser Eigenschaft ist kein Backingfield notwendig; Compiler erstellt es automatisch
        public string FavoriteFood { get; set; }

        public DateTime Birthdate { get; set; }

        public int Age 
        { 
            get 
            {
                return CalculateAge();
            } 
        }

        // Alternative Kurzschreibweise (mit Lambda '=>')
        public int Age2 => CalculateAge();

        #endregion

        #region Konstruktor

        public Animal(string name)
        {
            _name = name;

            // Wenn das Feld den gleichen Namen hat wie der Parameter
            // muessen wir this benutzen welches immer der Zeiger 
            // auf die aktuelle Objekt-Instanz ist.
            this.name = name;
        }

        // Wir koennen mit this auch einen anderen Konstruktor innerhalb der Klasse aufrufen
        public Animal(string name, DateTime birthdate) : this(name)
        {
            // Wir sparen uns die Zuweisung von name weil sie mit this bereits aufgerufen wird
            Birthdate = birthdate;
        }

        #endregion

        #region Methoden

        public void Dispose()
        {
            _isAlive = false;
            Console.WriteLine(_name + " is dead");
        }

        public void Walk()
        {
            Console.WriteLine("I'm walking");
        }

        // internal gilt nur innerhalb dieser Assembly, d.h. erzeugte DLL bze. nur dieses Projektes
        internal void Eat()
        {
            if (_isAlive)
            {
                Console.WriteLine(FavoriteFood + "... Yumi! 😀");
            }
        }

        private int CalculateAge()
        {
            TimeSpan diff = DateTime.Now - Birthdate;
            return diff.Days / 365;
        }

        #endregion
    }
}
