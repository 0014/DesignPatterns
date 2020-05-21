using AbstractFactoryPattern.Autos;

namespace AbstractFactoryPattern.Factories
{
    public interface IAutoFactory
    {
        public IAuto CreateSportsCar();

        public IAuto CreateLuxoryCar();

        public IAuto CreateEconomyCar();
    }
}
