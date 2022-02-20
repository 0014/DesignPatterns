using CommandPattern.Model;

namespace CommandPattern.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void DecreaseStockBy(int id, int quantity)
        {
            throw new NotImplementedException();
        }

        public Product FindBy(string name)
        {
            return new Product();
        }

        public int GetStockFor(int id)
        {
            throw new NotImplementedException();
        }

        public void IncreaseStockBy(int id, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
