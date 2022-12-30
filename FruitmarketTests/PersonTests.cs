using Fruitmarket;

namespace FruitmarketTests;

public class PersonTests
{
    [Fact]
    public void test_changeFirstname()
    {
        
        // ARRANGE
        var Person1 = new Person("dean","nikolic",new Address("Musterstreet 1", "17/5"));

        // ACT
        Person1.changeFirstname("Lukas");
        
        // ASSERT
        Assert.Equal("Lukas", Person1.Firstname);
    }
    [Fact]
    public void test_changeLastname()
    {
        
        // ARRANGE
        var Person1 = new Person("dean","nikolic",new Address("Musterstreet 1", "17/5"));

        // ACT
        Person1.changeLastname("Test_Lastname");
        
        // ASSERT
        Assert.Equal("Test_Lastname", Person1.Lastname);
    }
    [Fact]
    public void test_changeAddress()
    {
        
        // ARRANGE
        var Person1 = new Person("dean","nikolic",new Address("Musterstreet 1", "17/5"));
        var tempAddress = new Address("temp_street", "999");
        // ACT
        Person1.changeAddress(tempAddress);
        
        // ASSERT
        Assert.Equal("temp_street", Person1.Address.Street);
    }
}