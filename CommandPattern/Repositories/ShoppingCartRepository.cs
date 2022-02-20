using CommandPattern.Model;

namespace CommandPattern.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void DecreaseQuantity(int id)
        {
            throw new NotImplementedException();
        }

        public int GetItemQuantity(int id)
        {
            throw new NotImplementedException();
        }

        public void IncreaseQuantity(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveAll(int id)
        {
            throw new NotImplementedException();
        }
    }
}
