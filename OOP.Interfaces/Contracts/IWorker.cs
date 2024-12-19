namespace OOP.Interfaces.Contracts
{
    public interface IWorker : IPerson
    {
        public string Job { get; set; }

        string DoWork();
    }
}
