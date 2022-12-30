namespace Fruitmarket;

public class FruitsAndVegetables : Product
{
    
    public string Weight { get; set; }
    public bool IsFruit { get; set; }
#pragma warning disable CS8618
    protected FruitsAndVegetables() { }
#pragma warning restore CS8618
    public FruitsAndVegetables(Product product, string weight, bool isfruit) : base(product.Name, product.Price)
    {
        Weight = weight;
        IsFruit = isfruit;
    }

    public void changeWeight(string weight)
    {
        Weight = weight;
    }

    public void setStatus(bool isfruit)
    {
        IsFruit = isfruit;
    }
}