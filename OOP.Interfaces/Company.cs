using OOP.Interfaces.Contracts;

namespace OOP.Interfaces
{
    public class Company
    {
        public string Name { get; }

        public Company(string name)
        {
            Name = name;
        }

        // Wir initialisieren die Liste. Ansonsten waere sie null und 
        // beim ersten Zugriff wuerde eine NullReferenceException auftreten
        public List<IWorker> Employees { get; set; } = new List<IWorker>();

        public void Hire(IWorker worker)
        {
            Employees.Add(worker);
        }

        public void DoBusinessAsUsual()
        {
            foreach (var employee in Employees)
            {
                Console.WriteLine($"{employee.Name} ist dran als {employee.Job}!");
                employee.DoWork();
            }
        }
    }
}
