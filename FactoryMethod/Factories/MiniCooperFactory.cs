using FactoryMethod.Autos;

namespace FactoryMethod.Factories
{
    public class MiniCooperFactory : IAutoFactory
    {
        public IAuto CreateAutoMobile()
        {
            var mini = new MiniCooper();
            mini.SetName("Mini Cooper A");

            return mini;
        }
    }
}
