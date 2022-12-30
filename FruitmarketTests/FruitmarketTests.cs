using Fruitmarket;

namespace FruitmarketTests;

public class UnitTest1
{
    [Fact]
    public void test_changeOwner()
    {
        
            // ARRANGE
            var Owner1 = new Owner(new Person("max","mustermann",new Address("Musterstrasse","1")),"Musterstand");
            var Owner2 = new Owner(new Person("michael","mustertyp",new Address("Gasse Am Weg","11")),"Musterstand");

            var Market1 = new Market("Markt 01", new Address("Musterstrasse 1", "22"), Owner1);

            // ACT
            Market1.changeOwner(Owner2);
        
            // ASSERT
            Assert.Equal("michael", Owner2.Firstname);
        
    }
    [Fact]
    public void test_changeAddress()
    {
        
        // ARRANGE
        var Owner1 = new Owner(new Person("max","mustermann",new Address("Musterstrasse","1")),"Musterstand");
        var Market = new Market("Markt 01", new Address("Musterstrasse 1", "22"), Owner1);

        // ACT
        Market.changeAddress(new Address("Musterstrasse 2","22"));
        
        // ASSERT
        Assert.Equal("Musterstrasse 2", Market.Address.Street);
        
    }
    [Fact]
    public void test_addProducts()
    {
        
        var Owner1 = new Owner(new Person("max","mustermann",new Address("Musterstrasse","1")),"Musterstand");
        var Market = new Market("Markt 01", new Address("Musterstrasse 1", "22"), Owner1);
        var Product1 = new Product("Basket", 14.99M);
        var Product2 = new Product("Pillow", 20.00M);

        // ACT
        Market.addProducts(Product1);
        Market.addProducts(Product2);
        
        // ASSERT
        Assert.Equal(2, Market.Products.Count);
        
    }
    [Fact]
    public void test_removeProducts()
    {
        
        var Owner1 = new Owner(new Person("max","mustermann",new Address("Musterstrasse","1")),"Musterstand");
        var Market = new Market("Markt 01", new Address("Musterstrasse 1", "22"), Owner1);
        var Product1 = new Product("Basket", 14.99M);
        var Product2 = new Product("Pillow", 20.00M);

        // ACT
        Market.addProducts(Product1);
        Market.addProducts(Product2);
        Market.removeProducts(Product1);
        
        // ASSERT
        Assert.Equal(1, Market.Products.Count);
        
    }
   
}