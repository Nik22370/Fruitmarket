using System.Data.Common;

namespace Fruitmarket;

public class Market
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public Address Address { get; set; }
    public Owner Owner { get; set; }
    protected List<Product> _products = new List<Product>();
    public virtual IReadOnlyCollection<Product> Products => _products;

    public Market(string name, Address address, Owner owner)
    {
        Name = name;
        Address = address;
        Owner = owner;
    }

    public void changeOwner(Owner owner)
    {
        Owner = owner;
    }

    public void changeAddress(Address address)
    {
        Address = address;
    }

    public void addProducts(Product product)
    {
        _products.Add(product);
        
    }
    public void removeProducts(Product product)
    {
        _products.Remove(product);
        
    }

    public int countProducts()
    {
        return _products.Count;
    }
}