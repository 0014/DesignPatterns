using CommandPattern.Model;

namespace CommandPattern.Repositories
{
    public interface IShoppingCartRepository
    {
        void Add(Product product);
        int GetItemQuantity(int id);
        void IncreaseQuantity(int id);
        void DecreaseQuantity(int id);
        void RemoveAll(int id);
    }
}
