using System;

namespace Lab.ExceptionHandling.Loesung
{
    public enum Rechenoperation { Addition = 1, Subtraktion, Multiplikation, Division }

    class Program
    {
        static void Main(string[] args)
        {
            //Variable, welche Wiederholung definiert
            bool wiederholen;
            //Schleife f�r Wiederholung
            do
            {
                wiederholen = true;

                //Eingabe durch Benutzer
                string eingabe = GetEingabe();

                //Try-Block f�r Code, welche m�glicherweise Fehler verursacht
                try
                {
                    Term term = new Term(eingabe);

                    int ergebnis = BerechneTerm(term);

                    Console.WriteLine($"\t={ergebnis}");

                    wiederholen = false;
                }
                //Catch-Bl�cke zur Bearbeitung der Fehler
                catch (OverflowException)
                {
                    Console.WriteLine("Eine deiner Zahlen war zu gro� oder zu klein.\n");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Du hast ein nicht-erlaubtes Zeichen verwendet.\n");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Du hast versucht durch 0 zu teilen.\n");
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Du hast ein nicht-erlaubtes Rechenzeichen verwendet.\n");
                }
                catch (Exception)
                {

                }
            } while (wiederholen);
        }

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
                    //Teilung kann DivideByZeroException verursachen
                    return term.Zahl1 / term.Zahl2;
            }
        }
    }

    class Term
    {
        public string Eingabe { get; set; }
        public int Zahl1 { get; set; }
        public int Zahl2 { get; set; }
        public Rechenoperation Operation { get; set; }

        public Term(string term)
        {
            Eingabe = term;
            Operation = GetRechenoperation();

            //SplitTerm kann Null zur�ckgeben
            string[] zahlen = SplitTerm();

            //Parsing kann FormatExceptions und OverflowExceptions verursachen
            Zahl1 = int.Parse(zahlen[0]);
            Zahl2 = int.Parse(zahlen[1]);
        }

        private Rechenoperation GetRechenoperation()
        {
            if (Eingabe.Contains('+'))
                return Rechenoperation.Addition;
            else if (Eingabe.Contains('-'))
                return Rechenoperation.Subtraktion;
            else if (Eingabe.Contains('*'))
                return Rechenoperation.Multiplikation;
            else if (Eingabe.Contains('/'))
                return Rechenoperation.Division;
            else
                return 0;
        }

        private string[] SplitTerm()
        {
            switch (Operation)
            {
                case Rechenoperation.Addition:
                    return Eingabe.Split('+');
                case Rechenoperation.Subtraktion:
                    return Eingabe.Split('-');
                case Rechenoperation.Multiplikation:
                    return Eingabe.Split('*');
                case Rechenoperation.Division:
                    return Eingabe.Split('/');
            }
            return null; //Null-R�ckgabe kann sp�ter eine NullReferenceException verursachen
        }
    }
}

