using AbstractFactoryPattern.Autos;
using AbstractFactoryPattern.Autos.Bmw;

namespace AbstractFactoryPattern.Factories
{
    public class BmwFactory : IAutoFactory
    {
        public IAuto CreateSportsCar()
        {
            return new Bmw740I();
        }

        public IAuto CreateLuxoryCar()
        {
            return new BmwM3();
        }

        public IAuto CreateEconomyCar()
        {
            return new Bmw328I();
        }
    }
}
