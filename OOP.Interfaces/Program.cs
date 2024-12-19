using OOP.Interfaces.Data;

namespace OOP.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            var acmeInc = new Company("ACME Inc.");

            var bugs = new Bunny("Bugs", 42);
            var duffy = new Duck("Duffy");

            acmeInc.Hire(bugs);
            acmeInc.Hire(duffy);

            var clone = (Bunny)bugs.Clone();
            acmeInc.Hire(clone);

            acmeInc.DoBusinessAsUsual();
        }
    }
}
