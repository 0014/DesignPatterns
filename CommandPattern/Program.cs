using CommandPattern;
using CommandPattern.Repositories;

var shoppingCartRepository = new ShoppingCartRepository();
var productRepository = new ProductRepository();

var product = productRepository.FindBy("SM7B");

var addToCartCommand = new AddToCartCommand(shoppingCartRepository, productRepository, product);
var increaseQuantityCommand = new ChangeQuantityCommand(
    ChangeQuantityCommand.Operation.Increase,
    shoppingCartRepository,
    productRepository,
    product);

var manager = new CommandManager();
manager.Invoke(addToCartCommand);
manager.Invoke(increaseQuantityCommand);
manager.Invoke(increaseQuantityCommand);
manager.Invoke(increaseQuantityCommand);
manager.Invoke(increaseQuantityCommand);

Console.WriteLine("Added items to the shopping cart.");

manager.Undo();

Console.WriteLine("All the shopping car items are removed");