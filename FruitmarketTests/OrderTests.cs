using Fruitmarket;

namespace FruitmarketTests;

public class OrderTests
{
    [Fact]
    public void test_totalprice()
    {
        
        // ARRANGE
        var Person1 = new Person("dean","nikolic",new Address("Musterstreet 1", "17/5"));
        var Customer1 = new Customer(Person1, "ABC-123-456");
        var Order1 = new Order(Customer1);
        var Product1 = new Product("Basket", 14.99M);
        var Product2 = new Product("Pillow", 20.00M);
        // ACT
        Order1.addProduct(Product1);
        Order1.addProduct(Product2);

        // ASSERT
        Assert.Equal(34.99M, Order1.totalPrice());
    }
    
    [Fact]
    public void test_addproducts()
    {
        
        // ARRANGE
        var Person1 = new Person("dean","nikolic",new Address("Musterstreet 1", "17/5"));
        var Customer1 = new Customer(Person1, "ABC-123-456");
        var Order1 = new Order(Customer1);
        var Product1 = new Product("Basket", 14.99M);
        var Product2 = new Product("Pillow", 20.00M);
        // ACT
        Order1.addProduct(Product1);
        Order1.addProduct(Product2);

        // ASSERT
        Assert.Equal(34.99M, Order1.totalPrice());
    }
    [Fact]
    public void test_removeproducts()
    {
        
        // ARRANGE
        var Person1 = new Person("dean","nikolic",new Address("Musterstreet 1", "17/5"));
        var Customer1 = new Customer(Person1, "ABC-123-456");
        var Order1 = new Order(Customer1);
        var Product1 = new Product("Basket", 14.99M);
        var Product2 = new Product("Pillow", 20.00M);
        // ACT
        Order1.addProduct(Product1);
        Order1.removeProducts(Product1);
        Order1.addProduct(Product2);

        // ASSERT
        Assert.Equal(1, Order1.countProducts());
    }
}