namespace FactoryMethod.Autos
{
    public interface IAuto
    {
        string Name { get; }
        void SetName(string name);
        public void TurnOn();
        public void TurnOff();
    }
}