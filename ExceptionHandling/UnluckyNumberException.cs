namespace ExceptionHandling
{
    // Jede Art von Exception ist von der Basisklasse Exception abgeleitet.
    // Der Name sollte per Konvention immer das Postfix "Exception" enthalten.
    // d.h. keinenfalls UnluckyNumberError oder UnluckyNumber, ...
    public class UnluckyNumberException : Exception
    {
        public UnluckyNumberException(int number) 
            // Aufruf des Konstruktors aus der Basisklasse Exception
            : base($"Die Zahl {number} ist eine Unglückszahl.")
        {
        }
    }
}
