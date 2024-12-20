using System;

namespace Lab.ExceptionHandling.Vorgabe
{
    public enum Rechenoperation { Addition = 1, Subtraktion, Multiplikation, Division }

    class Program
    {
        //Füge in die Main()-Methode eine Try/Catch-Mechanik ein, welche mindestens vier verschiedene Exceptions abfängt und dem Benutzer eine
        //sinnvolle Fehlermeldung ausgibt. Etabliere zudem eine Mechanik, welche das Programm im Fehlerfall wiederholt.
        static void Main(string[] args)
        {
            string eingabe = GetEingabe();

            Term term = new Term(eingabe);

            int ergebnis = BerechneTerm(term);

            Console.WriteLine($"\t={ergebnis}");
        }

        //Codeänderungen sollen nur in der Main()-Methode stattfinden.
        static string GetEingabe()
        {
            Console.WriteLine("Bitte gib einen Term mit zwei Zahlen und einem Grundrechenoperator (+ - * /) ein (z.B.: 25+13):");
            return Console.ReadLine();
        }

        static int BerechneTerm(Term term)
        {
            switch (term.Operation)
            {
                case Rechenoperation.Addition:
                    return term.Zahl1 + term.Zahl2;
                case Rechenoperation.Subtraktion:
                    return term.Zahl1 - term.Zahl2;
                case Rechenoperation.Multiplikation:
                    return term.Zahl1 * term.Zahl2;
                default:
                    return term.Zahl1 / term.Zahl2;
            }
        }
    }
}
