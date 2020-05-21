using AbstractFactoryPattern.Autos;
using AbstractFactoryPattern.Autos.Mini;

namespace AbstractFactoryPattern.Factories
{
    public class MiniCooperFactory : IAutoFactory
    {
        public IAuto CreateSportsCar()
        {
            var mini = new MiniCooper();
            mini.AddSportPackage();

            return mini;
        }

        public IAuto CreateLuxoryCar()
        {
            var mini = new MiniCooper();
            mini.AddLuxoryPackage();

            return mini;
        }

        public IAuto CreateEconomyCar()
        {
            return new MiniCooper();
        }
    }
}
