using CommandPattern.Model;
using CommandPattern.Repositories;

namespace CommandPattern
{
    public class AddToCartCommand : ICommand
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IProductRepository _productRepository;
        private readonly Product _product;

        public AddToCartCommand(IShoppingCartRepository shoppingCartRepository, IProductRepository productRepository, Product product)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _productRepository = productRepository; 
            _product = product;
        }

        public bool CanExecute()
        {
            if (_product == null) return false;

            return _productRepository.GetStockFor(_product.Id) > 0;
        }

        public void Execute()
        {
            if (_product == null) return;

            _productRepository.DecreaseStockBy(_product.Id, 1);

            _shoppingCartRepository.Add(_product);
        }

        public void Undo()
        {
            if(_product == null) return;

            var quantity = _shoppingCartRepository.GetItemQuantity(_product.Id);

            _productRepository.IncreaseStockBy(_product.Id, quantity);

            _shoppingCartRepository.RemoveAll(_product.Id);
        }
    }
}
