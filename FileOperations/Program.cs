using FileOperations.Data;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FileOperations
{
    internal class Program
    {
        // Json Daten wurden von folgender URL bezogen: https://dummyjson.com/todos
        // Json-Datei erstellt und bei Properties > Copy to Output Directory gesetzt
        // Datenklassen wurden generiert mittels: Edit > Paste Special > Generate from JSON

        const string FILENAME = "todos.json";

        static void Main(string[] args)
        {
            Console.WriteLine("Textdatei einlesen und ausgeben");

            string text = File.ReadAllText(FILENAME);
            Console.WriteLine(text.Substring(0, 100) + "...");

            Console.WriteLine();
            Console.WriteLine("JSON-Datei einlesen und ausgeben");
            var list = JsonSerializer.Deserialize<TodoList>(text);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"  {i + 1}. {list.todos[i].todo}");
            }

            Console.WriteLine();
            Console.WriteLine("JSON-Datei schreiben");
            var json = JsonSerializer.Serialize(new TodoList
            {
                todos = new[]
                {
                    new Todo
                    {
                        todo = "Learn C#",
                        completed = false
                    },
                    new Todo {
                        todo = "Learn ASP.NET Core",
                        completed = true
                    },
                    new Todo {
                        todo = "Learn JSON",
                        completed = false
                    }
                }
            }, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText("todos-new.json", json);

            if (!File.Exists("todos-new.json"))
            {
                throw new Exception("Fehler beim Schreiben der Datei");
            }
            Console.WriteLine("Datei erfolgreich geschrieben!");
        }
    }
}
