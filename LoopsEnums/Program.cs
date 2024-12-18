namespace LoopsEnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Schleifen

            int current = 0;
            int end = 10;

            // Kopfgesteuerte Schleife: Wenn von Anfang an false wird Schleife nicht gestartet
            while (current < end)
            {
                Console.WriteLine("Current is smaller than end: " + current);
                current++;

                if (current == 5)
                {
                    // Schleife vorzeitig beenden mit break
                    break;
                }
            }
            Console.WriteLine("Loop ended");


            // Fussgesteuerte Schleife
            do
            {
                Console.WriteLine(current);
                --current;

                // Der Continue Befehl beendet den aktuellen Schleifendurchlauf
                // und laesst erneut die Bedingung pruefen. Ist sie wahr,
                // beginnt ein neuer Schleifendurchlauf
                continue;

            } while (current > 0);


            // For-Schleife
            for (int i = 0; i < 10; i += 2) // Kurzschreibweise fuer i = i + 2
            {
                Console.WriteLine("Index i == " + i);
            }

            int[] numbers = { 1, 1, 2, 3, 5, 8, 13, 21 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Number: " + numbers[i]);
            }

            foreach (int number in numbers)
            {
                Console.WriteLine("Number: " + number);
            }

            #endregion

            #region Enums

            // Wichtig: Enums muessen ausserhalb von Methoden oder Klassen
            // deklariert werden weil es deklarativ ist, deshalb siehe unten

            Weekday today = Weekday.Wednesday;
            Console.WriteLine($"Tag als Code geschrieben wurde war {today}.");

            Console.WriteLine("Welcher Tag ist dein Lieblingstag?");
            for (int i = 1; i < 8; i++)
            {
                Weekday day = (Weekday)i;
                Console.WriteLine($"{i}: {day}");
            }

            int selectedDay = int.Parse(Console.ReadLine());
            Console.WriteLine("Dein gewaehlter Lieblingstag ist " + (Weekday)selectedDay);

            Weekday parsedDay = Enum.Parse<Weekday>("Freitag");
            Console.WriteLine(parsedDay);

            #endregion

            #region Switch

            // Wenn wir jeden Wochtag behandeln wollten, muessten wir ein 7-fach verschachteltes if benutzen

            switch ((Weekday)selectedDay)
            {
                case Weekday.Monday:
                    Console.WriteLine("Wochenstart");
                    break;

                case Weekday.Tuesday:
                case Weekday.Wednesday:
                case Weekday.Thursday:
                    Console.WriteLine("Normaler Arbeitstag");
                    break;

                case Weekday.Friday:
                    Console.WriteLine("Letzter Arbeitstag");
                    break;

                case Weekday.Saturday:
                case Weekday.Sunday:
                    Console.WriteLine("Wochenende");
                    break;

                // Wenn die uebergebene Variable keinen der vordefinierten Zustaende hat, wird der Default-Fall ausgefuehrt
                default:
                    Console.WriteLine("Fehlerhafte Eingabe");
                    break;
            }

            #endregion
        }
    }

    enum Weekday
    {
        Monday = 1, // Wenn keine Zahl angegeben wird, dann startet enum automatisch bei 0
        Tuesday, // Compiler ergaenzt die Zuweisungen automatisch immer um 1 erhoeht
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
