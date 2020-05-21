namespace AbstractFactoryPattern.Autos
{
    public interface IAuto
    {
        string Name { get; }
        public void TurnOn(); 
        public void TurnOff();
    }
}