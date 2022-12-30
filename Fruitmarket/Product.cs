namespace Fruitmarket;

public class Product
{
    public int Id { get; private set; }
    public Guid Guid { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string ProductType { get; private set; } = default!;


    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
#pragma warning disable CS8618
    protected Product() { }
#pragma warning restore CS8618

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
