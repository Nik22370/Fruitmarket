namespace Fruitmarket;

public class Product
{
    public int Id { get; private set; }
    public Guid Guid { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void changePrice(decimal price)
    {
        Price = price;
    }

    public void changeName(string name)
    {
        Name = name;
    }

    public string nameAndPrice()
    {
        return Name + " " + Price;
    }
    
}
