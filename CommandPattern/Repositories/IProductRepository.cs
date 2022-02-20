namespace CommandPattern.Repositories
{
    public interface IProductRepository
    {
        void DecreaseStockBy(int id, int quantity);

        void IncreaseStockBy(int id, int quantity);

        int GetStockFor(int id);
    }
}
