using Fruitmarket;

namespace FruitmarketTests;

public class UnitTest1
{
    [Fact]
    public void test_changeOwner()
    {
        
            // ARRANGE
            var Market = new Market("Markt 01", new Address("Musterstrasse 1", "22"), new Owner());

            // ACT
            Market.changeAddress(new Address("Musterstrasse 2","22"));
        
            // ASSERT
            Assert.Equal("Musterstrasse 2", Market.Address.Street);
        
    }
    [Fact]
    public void test_changeAddress()
    {
        
        // ARRANGE
        var Market = new Market("Markt 01", new Address("Musterstrasse 1", "22"), new Owner());

        // ACT
        Market.changeAddress(new Address("Musterstrasse 2","22"));
        
        // ASSERT
        Assert.Equal("Musterstrasse 2", Market.Address.Street);
        
    }
    [Fact]
    public void test_addProducts()
    {
        
        
        
    }
    [Fact]
    public void test_removeProducts()
    {
        
        
        
    }
    [Fact]
    public void test_countProducts()
    {
        
        
        
    }
}