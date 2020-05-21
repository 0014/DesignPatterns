using FactoryMethod.Autos;

namespace FactoryMethod.Factories
{
    public class BmwFactory : IAutoFactory
    {
        public IAuto CreateAutoMobile()
        {
            return new Bmw("BMW M5 Cabriolet");
        }
    }
}
