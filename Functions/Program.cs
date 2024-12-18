


namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n1 = ReadDouble();
            var n2 = ReadDouble();

            var sumFromAdd = Add(n1, n2);
            Console.WriteLine("Summe: " + sumFromAdd);

            Console.WriteLine("Summe bilden aus 1.0, 2.1, 3.5, 4.2, 0.4");

            double[] numbers = new[] { 1.0, 2.1, 3.5, 4.2, 0.4 };
            var sumFromArray = Sum(numbers);
            Console.WriteLine("Als Array übergeben: " + sumFromArray);

            // Mit params Keyword koennen wir beliebig viele Argumente übergeben
            // Ohne params Keyword Fehlermeldung: No overload method 'Sum' takes 5 arguments
            var sumFromParams = Sum(1.0, 2.1, 3.5, 4.2, 0.4);
            Console.WriteLine("Mit params keyword: " + sumFromParams);

            int? sumFromAdd2 = Add(1, 2);
            Console.WriteLine("Summe: " + sumFromAdd2);

            int? sumFromAdd3 = Add(1, 2, 3);
            Console.WriteLine("Summe: " + sumFromAdd3);

            double input1 = ReadDoubleSave();

            Console.ReadKey();
        }

        // Wir setzen ein ? hinter den Typen um es als nullable zu deklarieren
        // Alternative (syntactic sugar) für Nullable<double>
        private static double? ReadDouble()
        {
            Console.Write("Gib eine Zahl ein: ");
            string? input = Console.ReadLine();
            if (input != null)
            {
                return double.Parse(input);
            }

            return null;

            // Hintergrundinfo:
            // Auch lt. ascii table "null terminator" \0 - nicht zu verwechseln mit numerischer 0
            // Aber in C# ist es das Keyword null
        }

        private static double ReadDoubleSave()
        {
            bool success;
            double result;

            do
            {
                Console.Write("Gib eine Zahl ein: ");
                string? input = Console.ReadLine();

                success = double.TryParse(input, out result);

                if (!success)
                {
                    Console.WriteLine("Fehlerhafte Eingabe. Bitte erneut versuchen.");
                }

            } while (!success);


            return result;
        }

        public static double? Add(double? value1, double? value2)
        {
            var result = value1 + value2;
            return result;
        }

        // Wir setzen fuer den dritten Parameter einen Default-Wert 0
        // d.h. wir koennen die Methode mit 2 oder 3 Parametern aufrufen
        // Wenn wir den Default auf 42 setzen wird auch immer 42 addiert
        public static int? Add(int? value1, int? value2, int? valueOptional = 0)
        {
            var result = value1 + value2 + valueOptional;
            return result;
        }

        public static double Sum(params double[] values)
        {
            // Result initialisiert mit 0
            double result = .0;

            foreach (var value in values)
            {
                // Jeden Wert zum Result hinzufügen
                result += value;
            }

            // Ergebnis zurückgeben
            return result;
        }
    }
}
