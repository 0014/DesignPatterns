using CommandPattern.Model;
using CommandPattern.Repositories;

namespace CommandPattern
{
    public class ChangeQuantityCommand : ICommand
    {
        public enum Operation
        {
            Increase,
            Decrease
        }

        private readonly Operation _operation;
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IProductRepository _productRepository;
        private readonly Product _product;

        public ChangeQuantityCommand(
            Operation operation,
            IShoppingCartRepository shoppingCartRepository,
            IProductRepository productRepository,
            Product product)
        {
            _operation = operation;
            _shoppingCartRepository = shoppingCartRepository;
            _productRepository = productRepository;
            _product = product;
        }

        public bool CanExecute()
        {
            switch (_operation)
            {
                case Operation.Increase:
                    return _productRepository.GetStockFor(_product.Id) - 1 >= 0;
                case Operation.Decrease:
                    return _shoppingCartRepository.GetItemQuantity(_product.Id) != 0;
            }

            return false;
        }

        public void Execute()
        {
            switch(_operation)
            {
                case Operation.Increase:
                    _productRepository.DecreaseStockBy(_product.Id, 1);
                    _shoppingCartRepository.IncreaseQuantity(_product.Id);
                    break;
                case Operation.Decrease:
                    _productRepository.IncreaseStockBy(_product.Id, 1);
                    _shoppingCartRepository.DecreaseQuantity(_product.Id);
                    break;
            }
        }

        public void Undo()
        {
            switch (_operation)
            {
                case Operation.Decrease:
                    _productRepository.DecreaseStockBy(_product.Id, 1);
                    _shoppingCartRepository.IncreaseQuantity(_product.Id);
                    break;
                case Operation.Increase:
                    _productRepository.IncreaseStockBy(_product.Id, 1);
                    _shoppingCartRepository.DecreaseQuantity(_product.Id);
                    break;
            }
        }
    }
}
