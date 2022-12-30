using Fruitmarket;

namespace FruitmarketTests;

public class ProductTests
{
    [Fact]
    public void test_changePrice()
    {
        
        // ARRANGE
        var Product1 = new Product("Basket", 14.99M);
        // ACT
        Product1.changePrice(15.99M);

        // ASSERT
        Assert.Equal(15.99M, Product1.Price);
    }
    [Fact]
    public void test_changeName()
    {
        
        // ARRANGE
        var Product1 = new Product("Basket", 14.99M);
        // ACT
        Product1.changeName("Basket 2.0");

        // ASSERT
        Assert.Equal("Basket 2.0", Product1.Name);
    }
    [Fact]
    public void test_nameAndPrice()
    {
        
        // ARRANGE
        var Product1 = new Product("Basket", 14.99M);
        // ACT

        // ASSERT
        Assert.Equal("Basket 14,99", Product1.nameAndPrice());
    }
}