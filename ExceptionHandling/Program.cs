namespace ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            int? number;

            do
            {
                Console.Write("Bitte eine Zahl eingeben:\t");

                // Wir sehen mit IntelliSense welche Exceptions Console.ReadLine() werfen koennte.
                var input = Console.ReadLine();

                number = ReadNumber(input);
            }
            while (!number.HasValue);

            Console.WriteLine($"Die eingegebene Zahl ist: {number}");
        }


        /// <summary>
        /// Grundsätzlich gilt: Sog. Exception-Flow sollte vermieden werden. D.h.
        /// wenn wir proaktiv Fehler verhindern können, sollten wir dies tun.
        /// Als Beispiel können wir variablen auf null abfragen oder vor einer Division
        /// ob der Divisor 0 ist.
        /// </summary>
        /// <returns></returns>
        public static int? ReadNumber(string? input)
        {
            // Im Try-Block steht der Code, welcher potenyiell Fehler produzieren kann
            try
            {

                // Wir sehen mit IntelliSense welche Exceptions int.Parse() werfen koennte.
                var result = int.Parse(input);

                if (result == 99)
                {
                    throw new UnluckyNumberException(result);
                }

                return result;
            }

            catch (UnluckyNumberException ex)
            {
                // In der Praxis wuerden wir typischer Weise die Exception Informationen in ein sog. Log-File schreiben
                // logger.Error(ex.Message);

                Console.WriteLine(ex.Message);

                // Wir wollen die Exception hier nicht "verschlucken" sondern sie weiter "hoch" werfen
                throw;
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Es wurde keine Eingabe getaetigt.");
            }

            catch (FormatException ex)
            {
                Console.WriteLine($"{input} ist keine gueltige Zahl.");
            }

            // Allgemeine Exception Basisklasse von der jede andere Exception ausnahmslos abgeleitet wird
            // Der allgemeine Block steht immer als letzter Block in einem try-catch
            catch (Exception ex)
            {
                // Hier wird ausnahmslos alles gefangen
                Console.WriteLine("Ein unbekannter Fehler ist aufgetreten:");
                Console.WriteLine(ex.Message);
            }

            // Optionaler Finally-Block wird in jedem Fall immer ausgefuehrt
            finally
            {
                // Typischer Use-Case waere es eine DB-Verbindung oder Dateizugriff aufzuraeumen.
                // file.Dispose();
                // connection.Close();
                Console.WriteLine("Wird immer ausgefuehrt.");
            }

            return null;
        }
    }
}
