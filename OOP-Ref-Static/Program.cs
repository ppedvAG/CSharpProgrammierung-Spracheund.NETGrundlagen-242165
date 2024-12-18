
using System.Text;

namespace OOP_Ref_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Wenn keine Zuweisung ist bunny standardmäßig null
            Creature bunny; // Creature bunny = null;

            bunny = new Creature("🐰");

            var wolf = new Creature("🐺");
            var duck = new Creature("🦆");
            var cat = new Creature("🐈");

            var result = bunny.DoWork();

            // Auf static greifen wir zu indem wir direkt den Klassennamen verwenden.
            Creature.ShowCount();

            Console.WriteLine();

            bunny.Dispose();
            wolf.Dispose();
            duck.Dispose();
            cat.Dispose();

            Creature.ShowCount();

            Console.WriteLine();

            // Fuer Disposable Objekte gibt es das Keyword using; 
            // Nach dem using wird der Speicher eines Disposables automatisch aufgeraeumt
            using (var snake = new Creature("🐍"))
            {
                snake.DoWork();
            }

            Creature.ShowCount();

            // Praktisches Beispiel fuer IDisposable ist das einlesen von Dateien

            // Ein FileStream ist auch gleizeitig ein IDisposable
            //using(IDisposable stream = File.OpenRead("Greetings.txt"))
            using (FileStream stream = File.OpenRead("Greetings.txt"))
            {
                var content = ReadFileContent(stream);

                Console.WriteLine("Inhalt von Greetings.txt ist ");
                Console.WriteLine(content);

                // Die Datei muss am Ende wieder freigegeben werden
                // weshalb Dispose aufgerufen werden muss bzw.

                //stream.Dispose();

                // passiert das hier automatisch weil wir in einem using-block sind
            }
        }

        /// <summary>
        /// Aus Dokumentation kopiert.
        /// https://docs.microsoft.com/en-us/dotnet/api/system.io.filestream?view=net-6.0
        /// </summary>
        /// <param name="fsSource"></param>
        /// <returns></returns>
        private static object ReadFileContent(FileStream stream)
        {
            var result = "";
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);
            int readLen;
            while ((readLen = stream.Read(b, 0, b.Length)) > 0)
            {
                result += temp.GetString(b, 0, readLen);
            }
            return result;
        }
    }
}
