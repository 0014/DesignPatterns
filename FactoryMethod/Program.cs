using System.Reflection;
using FactoryMethod.Factories;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoFactory = LoadFactory();

            var car = autoFactory.CreateAutoMobile();

            car.TurnOn();
            car.TurnOff();
        }

        static IAutoFactory LoadFactory()
        {
            var factoryName = Properties.Resources.FactoryName;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
    }
}
