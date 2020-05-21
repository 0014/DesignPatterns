using FactoryMethod.Autos;

namespace FactoryMethod.Factories
{
    public interface IAutoFactory
    {
        public IAuto CreateAutoMobile();
    }
}
