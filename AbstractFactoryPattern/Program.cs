using System;
using System.Reflection;
using AbstractFactoryPattern.Factories;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoFactory = LoadFactory();

            Console.WriteLine(@"SPORTS CAR");
            var car = autoFactory.CreateSportsCar();
            car.TurnOn();
            car.TurnOff();

            Console.WriteLine(@"LUXORY CAR");
            car = autoFactory.CreateLuxoryCar();
            car.TurnOn();
            car.TurnOff();

            Console.WriteLine(@"ECONOMY CAR");
            car = autoFactory.CreateEconomyCar();
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
